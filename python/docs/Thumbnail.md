# Thumbnail


## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**relative_path** | **str** |  | [optional] 
**content_type** | **str** |  | [optional] 
**url** | **str** |  | [optional] 

## Example

```python
from openapi_client.models.thumbnail import Thumbnail

# TODO update the JSON string below
json = "{}"
# create an instance of Thumbnail from a JSON string
thumbnail_instance = Thumbnail.from_json(json)
# print the JSON string representation of the object
print(Thumbnail.to_json())

# convert the object into a dict
thumbnail_dict = thumbnail_instance.to_dict()
# create an instance of Thumbnail from a dict
thumbnail_from_dict = Thumbnail.from_dict(thumbnail_dict)
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


