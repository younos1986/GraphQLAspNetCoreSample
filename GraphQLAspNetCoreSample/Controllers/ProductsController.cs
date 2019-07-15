using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DomainModel.GraphQLQueries;
using DomainModel.Models;
using GraphQL;
using GraphQL.Types;
using Microsoft.AspNetCore.Mvc;

namespace GraphQLAspNetCoreSample.Controllers
{
    //[Route("api/[controller]")]
    [Route("graphql")]
    [ApiController]
    public class ProductsController : ControllerBase
    {

        private readonly TestContext _db;
        private readonly IDocumentExecuter _documentExecuter;
        private readonly ISchema _schema;
        public ProductsController(ISchema schema, IDocumentExecuter documentExecuter)
        {
            _schema = schema;
            _documentExecuter = documentExecuter;
        }


        [HttpPost]
        public async Task<IActionResult> Post([FromBody] GraphQLQuery query)
        {
            if (query == null) { throw new ArgumentNullException(nameof(query)); }
            var inputs = query.Variables.ToInputs();


            var executionOptions = new ExecutionOptions
            {
                Schema = _schema,
                Query = query.Query,
                Inputs = inputs
            };

            var result = await _documentExecuter.ExecuteAsync(executionOptions).ConfigureAwait(false);

            if (result.Errors?.Count > 0)
            {
                return BadRequest(result);
            }

            return Ok(result);
        }

        //public async Task<IActionResult> Post([FromBody] GraphQLQuery query)
        //{
        //    var inputs = query.Variables.ToInputs();

        //    var schema = new Schema
        //    {
        //        Query = new ProductQuery(_db)
        //    };

        //    var result = await new DocumentExecuter().ExecuteAsync(_ =>
        //    {
        //        _.Schema = schema;
        //        _.Query = query.Query;
        //        _.OperationName = query.OperationName;
        //        _.Inputs = inputs;
        //    });

        //    if (result.Errors?.Count > 0)
        //    {
        //        var err = result.Errors.FirstOrDefault();
        //        return BadRequest(err?.Message);
        //    }

        //    return Ok(result);
        //}


        // GET api/values
        [HttpGet]
        public ActionResult Get()
        {





            return null;
        }


    }
}
