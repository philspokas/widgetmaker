import {
  Domain, getEnumMeta, solidify, ModelType, ObjectType,
  PrimitiveProperty, ForeignKeyProperty, PrimaryKeyProperty,
  ModelCollectionNavigationProperty, ModelReferenceNavigationProperty,
  HiddenAreas, BehaviorFlags
} from 'coalesce-vue/lib/metadata'


const domain: Domain = { enums: {}, types: {}, services: {} }
export const WidgetCategory = domain.enums.WidgetCategory = {
  name: "WidgetCategory",
  displayName: "Widget Category",
  type: "enum",
  ...getEnumMeta<"Whizbangs"|"Sprecklesprockets"|"Discombobulators">([
  {
    value: 0,
    strValue: "Whizbangs",
    displayName: "Whizbangs",
  },
  {
    value: 1,
    strValue: "Sprecklesprockets",
    displayName: "Sprecklesprockets",
  },
  {
    value: 2,
    strValue: "Discombobulators",
    displayName: "Discombobulators",
  },
  ]),
}
export const Inventory = domain.types.Inventory = {
  name: "Inventory",
  displayName: "Inventory",
  get displayProp() { return this.props.inventoryId }, 
  type: "model",
  controllerRoute: "Inventory",
  get keyProp() { return this.props.inventoryId }, 
  behaviorFlags: 7 as BehaviorFlags,
  props: {
    inventoryId: {
      name: "inventoryId",
      displayName: "Inventory Id",
      type: "number",
      role: "primaryKey",
      hidden: 3 as HiddenAreas,
    },
    widgetId: {
      name: "widgetId",
      displayName: "Widget Id",
      type: "number",
      role: "foreignKey",
      get principalKey() { return (domain.types.Widget as ModelType).props.widgetId as PrimaryKeyProperty },
      get principalType() { return (domain.types.Widget as ModelType) },
      get navigationProp() { return (domain.types.Inventory as ModelType).props.widget as ModelReferenceNavigationProperty },
      hidden: 3 as HiddenAreas,
      rules: {
        required: val => val != null || "Widget is required.",
      }
    },
    widget: {
      name: "widget",
      displayName: "Widget",
      type: "model",
      get typeDef() { return (domain.types.Widget as ModelType) },
      role: "referenceNavigation",
      get foreignKey() { return (domain.types.Inventory as ModelType).props.widgetId as ForeignKeyProperty },
      get principalKey() { return (domain.types.Widget as ModelType).props.widgetId as PrimaryKeyProperty },
      dontSerialize: true,
    },
    count: {
      name: "count",
      displayName: "Count",
      type: "number",
      role: "value",
      rules: {
        required: val => val != null || "Count is required.",
      }
    },
    createdOn: {
      name: "createdOn",
      displayName: "Created On",
      type: "date",
      dateKind: "datetime",
      role: "value",
    },
  },
  methods: {
  },
  dataSources: {
  },
}
export const Widget = domain.types.Widget = {
  name: "Widget",
  displayName: "Widget",
  get displayProp() { return this.props.name }, 
  type: "model",
  controllerRoute: "Widget",
  get keyProp() { return this.props.widgetId }, 
  behaviorFlags: 7 as BehaviorFlags,
  props: {
    widgetId: {
      name: "widgetId",
      displayName: "Widget Id",
      type: "number",
      role: "primaryKey",
      hidden: 3 as HiddenAreas,
    },
    name: {
      name: "name",
      displayName: "Name",
      type: "string",
      role: "value",
      rules: {
        required: val => (val != null && val !== '') || "Name is required.",
      }
    },
    category: {
      name: "category",
      displayName: "Category",
      type: "enum",
      get typeDef() { return domain.enums.WidgetCategory },
      role: "value",
      rules: {
        required: val => val != null || "Category is required.",
      }
    },
    inventedOn: {
      name: "inventedOn",
      displayName: "Invented On",
      type: "date",
      dateKind: "datetime",
      role: "value",
    },
  },
  methods: {
  },
  dataSources: {
  },
}

interface AppDomain extends Domain {
  enums: {
    WidgetCategory: typeof WidgetCategory
  }
  types: {
    Inventory: typeof Inventory
    Widget: typeof Widget
  }
  services: {
  }
}

solidify(domain)

export default domain as unknown as AppDomain
