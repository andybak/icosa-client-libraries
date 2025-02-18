extends Resource
class_name AssetResource

# THIS FILE WAS AUTOMATICALLY GENERATED by the OpenAPI Generator project.
# For more information on how to customize templates, see:
# https://openapi-generator.tech
# https://github.com/OpenAPITools/openapi-generator/tree/master/modules/openapi-generator/src/main/resources/gdscript
# The OpenAPI Generator Community, © Public Domain, 2022

# AssetResource Model


# Required: True
# isArray: false
@export var relativePath: String:
	set(value):
		__relativePath__was__set = true
		relativePath = value
var __relativePath__was__set := false

# Required: True
# isArray: false
@export var contentType: String:
	set(value):
		__contentType__was__set = true
		contentType = value
var __contentType__was__set := false

# Required: True
# isArray: false
@export var url: String:
	set(value):
		__url__was__set = true
		url = value
var __url__was__set := false


func bzz_collect_missing_properties() -> Array:
	var bzz_missing_properties := Array()
	if not self.__relativePath__was__set:
		bzz_missing_properties.append("relativePath")
	if not self.__contentType__was__set:
		bzz_missing_properties.append("contentType")
	if not self.__url__was__set:
		bzz_missing_properties.append("url")
	return bzz_missing_properties


func bzz_normalize() -> Dictionary:
	var bzz_dictionary := Dictionary()
	if self.__relativePath__was__set:
		bzz_dictionary["relativePath"] = self.relativePath
	if self.__contentType__was__set:
		bzz_dictionary["contentType"] = self.contentType
	if self.__url__was__set:
		bzz_dictionary["url"] = self.url
	return bzz_dictionary


# Won't work for JSON+LD
static func bzz_denormalize_single(from_dict: Dictionary):
	var me := new()
	if from_dict.has("relativePath"):
		me.relativePath = from_dict["relativePath"]
	if from_dict.has("contentType"):
		me.contentType = from_dict["contentType"]
	if from_dict.has("url"):
		me.url = from_dict["url"]
	return me


# Won't work for JSON+LD
static func bzz_denormalize_multiple(from_array: Array):
	var mes := Array()
	for element in from_array:
		if element is Array:
			mes.append(bzz_denormalize_multiple(element))
		elif element is Dictionary:
			# TODO: perhaps check first if it looks like a match or an intermediate container
			mes.append(bzz_denormalize_single(element))
		else:
			mes.append(element)
	return mes

