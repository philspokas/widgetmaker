
using IntelliTect.Coalesce;
using IntelliTect.Coalesce.Api;
using IntelliTect.Coalesce.Api.Behaviors;
using IntelliTect.Coalesce.Api.Controllers;
using IntelliTect.Coalesce.Api.DataSources;
using IntelliTect.Coalesce.Mapping;
using IntelliTect.Coalesce.Mapping.IncludeTrees;
using IntelliTect.Coalesce.Models;
using IntelliTect.Coalesce.TypeDefinition;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using widgetmaker.Web.Models;

namespace widgetmaker.Web.Api
{
    [Route("api/Inventory")]
    [Authorize]
    [ServiceFilter(typeof(IApiActionFilter))]
    public partial class InventoryController
        : BaseApiController<widgetmaker.Data.Models.Inventory, InventoryDtoGen, widgetmaker.Data.AppDbContext>
    {
        public InventoryController(CrudContext<widgetmaker.Data.AppDbContext> context) : base(context)
        {
            GeneratedForClassViewModel = context.ReflectionRepository.GetClassViewModel<widgetmaker.Data.Models.Inventory>();
        }

        [HttpGet("get/{id}")]
        [Authorize]
        public virtual Task<ItemResult<InventoryDtoGen>> Get(
            int id,
            DataSourceParameters parameters,
            IDataSource<widgetmaker.Data.Models.Inventory> dataSource)
            => GetImplementation(id, parameters, dataSource);

        [HttpGet("list")]
        [Authorize]
        public virtual Task<ListResult<InventoryDtoGen>> List(
            ListParameters parameters,
            IDataSource<widgetmaker.Data.Models.Inventory> dataSource)
            => ListImplementation(parameters, dataSource);

        [HttpGet("count")]
        [Authorize]
        public virtual Task<ItemResult<int>> Count(
            FilterParameters parameters,
            IDataSource<widgetmaker.Data.Models.Inventory> dataSource)
            => CountImplementation(parameters, dataSource);

        [HttpPost("save")]
        [Authorize]
        public virtual Task<ItemResult<InventoryDtoGen>> Save(
            [FromForm] InventoryDtoGen dto,
            [FromQuery] DataSourceParameters parameters,
            IDataSource<widgetmaker.Data.Models.Inventory> dataSource,
            IBehaviors<widgetmaker.Data.Models.Inventory> behaviors)
            => SaveImplementation(dto, parameters, dataSource, behaviors);

        [HttpPost("bulkSave")]
        [Authorize]
        public virtual Task<ItemResult<InventoryDtoGen>> BulkSave(
            [FromBody] BulkSaveRequest dto,
            [FromQuery] DataSourceParameters parameters,
            [FromServices] IDataSourceFactory dataSourceFactory,
            [FromServices] IBehaviorsFactory behaviorsFactory)
            => BulkSaveImplementation(dto, parameters, dataSourceFactory, behaviorsFactory);

        [HttpPost("delete/{id}")]
        [Authorize]
        public virtual Task<ItemResult<InventoryDtoGen>> Delete(
            int id,
            IBehaviors<widgetmaker.Data.Models.Inventory> behaviors,
            IDataSource<widgetmaker.Data.Models.Inventory> dataSource)
            => DeleteImplementation(id, new DataSourceParameters(), dataSource, behaviors);
    }
}
