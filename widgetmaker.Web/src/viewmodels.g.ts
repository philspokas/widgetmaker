import * as $metadata from './metadata.g'
import * as $models from './models.g'
import * as $apiClients from './api-clients.g'
import { ViewModel, ListViewModel, ServiceViewModel, DeepPartial, defineProps } from 'coalesce-vue/lib/viewmodel'

export interface InventoryViewModel extends $models.Inventory {
  inventoryId: number | null;
  widgetId: number | null;
  count: number | null;
  createdOn: Date | null;
}
export class InventoryViewModel extends ViewModel<$models.Inventory, $apiClients.InventoryApiClient, number> implements $models.Inventory  {
  
  constructor(initialData?: DeepPartial<$models.Inventory> | null) {
    super($metadata.Inventory, new $apiClients.InventoryApiClient(), initialData)
  }
}
defineProps(InventoryViewModel, $metadata.Inventory)

export class InventoryListViewModel extends ListViewModel<$models.Inventory, $apiClients.InventoryApiClient, InventoryViewModel> {
  
  constructor() {
    super($metadata.Inventory, new $apiClients.InventoryApiClient())
  }
}


export interface WidgetViewModel extends $models.Widget {
  widgetId: number | null;
  name: string | null;
  category: $models.WidgetCategory | null;
  inventedOn: Date | null;
}
export class WidgetViewModel extends ViewModel<$models.Widget, $apiClients.WidgetApiClient, number> implements $models.Widget  {
  
  constructor(initialData?: DeepPartial<$models.Widget> | null) {
    super($metadata.Widget, new $apiClients.WidgetApiClient(), initialData)
  }
}
defineProps(WidgetViewModel, $metadata.Widget)

export class WidgetListViewModel extends ListViewModel<$models.Widget, $apiClients.WidgetApiClient, WidgetViewModel> {
  
  constructor() {
    super($metadata.Widget, new $apiClients.WidgetApiClient())
  }
}


const viewModelTypeLookup = ViewModel.typeLookup = {
  Inventory: InventoryViewModel,
  Widget: WidgetViewModel,
}
const listViewModelTypeLookup = ListViewModel.typeLookup = {
  Inventory: InventoryListViewModel,
  Widget: WidgetListViewModel,
}
const serviceViewModelTypeLookup = ServiceViewModel.typeLookup = {
}

