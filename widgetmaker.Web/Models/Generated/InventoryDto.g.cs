using IntelliTect.Coalesce;
using IntelliTect.Coalesce.Mapping;
using IntelliTect.Coalesce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;

namespace widgetmaker.Web.Models
{
    public partial class InventoryDtoGen : GeneratedDto<widgetmaker.Data.Models.Inventory>
    {
        public InventoryDtoGen() { }

        private int? _InventoryId;
        private int? _WidgetId;
        private widgetmaker.Web.Models.WidgetDtoGen _Widget;
        private int? _Count;
        private System.DateTimeOffset? _CreatedOn;

        public int? InventoryId
        {
            get => _InventoryId;
            set { _InventoryId = value; Changed(nameof(InventoryId)); }
        }
        public int? WidgetId
        {
            get => _WidgetId;
            set { _WidgetId = value; Changed(nameof(WidgetId)); }
        }
        public widgetmaker.Web.Models.WidgetDtoGen Widget
        {
            get => _Widget;
            set { _Widget = value; Changed(nameof(Widget)); }
        }
        public int? Count
        {
            get => _Count;
            set { _Count = value; Changed(nameof(Count)); }
        }
        public System.DateTimeOffset? CreatedOn
        {
            get => _CreatedOn;
            set { _CreatedOn = value; Changed(nameof(CreatedOn)); }
        }

        /// <summary>
        /// Map from the domain object to the properties of the current DTO instance.
        /// </summary>
        public override void MapFrom(widgetmaker.Data.Models.Inventory obj, IMappingContext context, IncludeTree tree = null)
        {
            if (obj == null) return;
            var includes = context.Includes;

            this.InventoryId = obj.InventoryId;
            this.WidgetId = obj.WidgetId;
            this.Count = obj.Count;
            this.CreatedOn = obj.CreatedOn;
            if (tree == null || tree[nameof(this.Widget)] != null)
                this.Widget = obj.Widget.MapToDto<widgetmaker.Data.Models.Widget, WidgetDtoGen>(context, tree?[nameof(this.Widget)]);

        }

        /// <summary>
        /// Map from the current DTO instance to the domain object.
        /// </summary>
        public override void MapTo(widgetmaker.Data.Models.Inventory entity, IMappingContext context)
        {
            var includes = context.Includes;

            if (OnUpdate(entity, context)) return;

            if (ShouldMapTo(nameof(InventoryId))) entity.InventoryId = (InventoryId ?? entity.InventoryId);
            if (ShouldMapTo(nameof(WidgetId))) entity.WidgetId = (WidgetId ?? entity.WidgetId);
            if (ShouldMapTo(nameof(Count))) entity.Count = (Count ?? entity.Count);
            if (ShouldMapTo(nameof(CreatedOn))) entity.CreatedOn = CreatedOn;
        }

        /// <summary>
        /// Map from the current DTO instance to a new instance of the domain object.
        /// </summary>
        public override widgetmaker.Data.Models.Inventory MapToNew(IMappingContext context)
        {
            var includes = context.Includes;

            var entity = new widgetmaker.Data.Models.Inventory()
            {
                WidgetId = (WidgetId ?? default),
                Count = (Count ?? default),
            };

            if (OnUpdate(entity, context)) return entity;
            if (ShouldMapTo(nameof(InventoryId))) entity.InventoryId = (InventoryId ?? entity.InventoryId);
            if (ShouldMapTo(nameof(CreatedOn))) entity.CreatedOn = CreatedOn;

            return entity;
        }
    }
}
