import * as $metadata from './metadata.g'
import * as $models from './models.g'
import { AxiosClient, ModelApiClient, ServiceApiClient, ItemResult, ListResult } from 'coalesce-vue/lib/api-client'
import { AxiosPromise, AxiosResponse, AxiosRequestConfig } from 'axios'

export class InventoryApiClient extends ModelApiClient<$models.Inventory> {
  constructor() { super($metadata.Inventory) }
}


export class WidgetApiClient extends ModelApiClient<$models.Widget> {
  constructor() { super($metadata.Widget) }
}


