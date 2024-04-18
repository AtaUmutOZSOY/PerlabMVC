using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;
using System.Linq;

namespace Core.Utilities.Swagger
{
    public class OrderTagsDocumentFilter : IDocumentFilter
    {
        public void Apply(OpenApiDocument swaggerDoc, DocumentFilterContext context)
        {
            var sortedPaths = new OpenApiPaths();

            foreach (var entry in swaggerDoc.Paths.OrderBy(entry => entry.Key))
            {
                sortedPaths.Add(entry.Key, SortOperations(entry.Value));
            }

            swaggerDoc.Paths = sortedPaths;
        }

        private OpenApiPathItem SortOperations(OpenApiPathItem pathItem)
        {
            var sortedOperations = new OpenApiPathItem();
            foreach (var operation in pathItem.Operations.OrderBy(op => op.Key.ToString()))
            {
                sortedOperations.AddOperation(operation.Key, operation.Value);
            }

            return sortedOperations;
        }
    }
}
