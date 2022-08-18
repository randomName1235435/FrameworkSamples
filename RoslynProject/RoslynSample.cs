using Microsoft.Build.Locator;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.MSBuild;

namespace RoslynProject
{
    public class RoslynSample
    {
        /*
         * Nuget Packages:
         * Microsoft.CodeAnalysis.CSharp.Workspaces
         * Microsoft.CodeAnalysis.CSharp
         * Microsoft.CodeAnalysis.Common
         * Microsoft.CodeAnalysis.Workspaces.MSBuild
         * Microsoft.CodeAnalysis.Workspaces.Common
         * Microsoft.Build.Locator
         * Nuget.ProjectModel
         
            Protip:
            Look at SyntaxVisualizer in VS (install vs sdk & compiler toolz), u can see in there every node in syntax tree
         */

        private async Task SampleWorkspace()
        {
            MSBuildLocator.RegisterDefaults();

            var workspace = MSBuildWorkspace.Create();
            //adhoc for unittests
            //msbuild for most of the time
            //visual studio for vs extension (almost same as msbuild)

            workspace.LoadMetadataForReferencedProjects = true;

            workspace.WorkspaceFailed += Workspace_WorkspaceFailed;

            var solution = await workspace.OpenSolutionAsync("Sample.sln");

            foreach (var document in solution.Projects.SelectMany(i => i.Documents))
            {
                var root = await document.GetSyntaxRootAsync();
                if (root == null) continue;

                foreach (var typeDeclarationSyntax in root.DescendantNodes().OfType<BaseTypeDeclarationSyntax>())
                {
                    //not so fast :| better use CSharpSyntaxWalker
                    var namespaceDeclarationSyntax = typeDeclarationSyntax.FirstAncestorOrSelf<NamespaceDeclarationSyntax>();
                    var typeName = typeDeclarationSyntax.Identifier.Text;
                    var namespaceName = namespaceDeclarationSyntax?.Name.ToString();
                }
            }

            //with walker
            var walker = new SyntaxWalker();
            foreach (var document in solution.Projects.SelectMany(i => i.Documents))
            {
                var root = await document.GetSyntaxRootAsync();
                if (root == null) continue;
                walker.Visit(root); // fast
            }

            //compilation
            foreach (var project in solution.Projects)
            {
                var compilation = await project.GetCompilationAsync();
                if (compilation == null) continue;
                foreach (var document in project.Documents)
                {
                    var tree = await document.GetSyntaxTreeAsync();
                    if (tree == null) continue;

                    var model = compilation.GetSemanticModel(tree);
                    var root = await tree.GetRootAsync();

                    foreach (var typeDeclarationSyntax in root.DescendantNodes().OfType<BaseTypeDeclarationSyntax>())
                    {
                        if (model.GetDeclaredSymbol(typeDeclarationSyntax) is INamedTypeSymbol symbol)
                        {
                            var name = symbol.TypeKind.ToString() + symbol.ContainingNamespace + symbol.Name;

                            foreach (var methodSymbol in symbol.GetMembers().OfType<IMethodSymbol>())
                            {
                                if (!methodSymbol.IsImplicitlyDeclared)
                                {
                                    var methodname = methodSymbol.Name;
                                }
                            }
                        }

                    }
                }
            }
        }

        private class SyntaxWalker : CSharpSyntaxWalker
        {
            public override void VisitClassDeclaration(ClassDeclarationSyntax node)
            {
                base.VisitClassDeclaration(node);
                var namespaceDeclarationSyntax = node.FirstAncestorOrSelf<NamespaceDeclarationSyntax>();
                var typeName = node.Identifier.Text;
                var namespaceName = namespaceDeclarationSyntax?.Name.ToString();
                //fast
            }
            public override void VisitInterfaceDeclaration(InterfaceDeclarationSyntax node)
            {
                base.VisitInterfaceDeclaration(node);
            }
        }


        private void Workspace_WorkspaceFailed(object? sender, Microsoft.CodeAnalysis.WorkspaceDiagnosticEventArgs e)
        {

        }
    }
}