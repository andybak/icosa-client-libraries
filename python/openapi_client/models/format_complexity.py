# coding: utf-8

"""
    NinjaAPI

    No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)

    The version of the OpenAPI document: 1.0.0
    Generated by OpenAPI Generator (https://openapi-generator.tech)

    Do not edit the class manually.
"""  # noqa: E501


from __future__ import annotations
import pprint
import re  # noqa: F401
import json

from pydantic import BaseModel, ConfigDict, Field, StrictInt
from typing import Any, ClassVar, Dict, List, Optional
from typing import Optional, Set
from typing_extensions import Self

class FormatComplexity(BaseModel):
    """
    FormatComplexity
    """ # noqa: E501
    triangle_count: Optional[StrictInt] = Field(default=None, alias="triangleCount")
    lod_hint: Optional[StrictInt] = Field(default=None, alias="lodHint")
    __properties: ClassVar[List[str]] = ["triangleCount", "lodHint"]

    model_config = ConfigDict(
        populate_by_name=True,
        validate_assignment=True,
        protected_namespaces=(),
    )


    def to_str(self) -> str:
        """Returns the string representation of the model using alias"""
        return pprint.pformat(self.model_dump(by_alias=True))

    def to_json(self) -> str:
        """Returns the JSON representation of the model using alias"""
        # TODO: pydantic v2: use .model_dump_json(by_alias=True, exclude_unset=True) instead
        return json.dumps(self.to_dict())

    @classmethod
    def from_json(cls, json_str: str) -> Optional[Self]:
        """Create an instance of FormatComplexity from a JSON string"""
        return cls.from_dict(json.loads(json_str))

    def to_dict(self) -> Dict[str, Any]:
        """Return the dictionary representation of the model using alias.

        This has the following differences from calling pydantic's
        `self.model_dump(by_alias=True)`:

        * `None` is only added to the output dict for nullable fields that
          were set at model initialization. Other fields with value `None`
          are ignored.
        """
        excluded_fields: Set[str] = set([
        ])

        _dict = self.model_dump(
            by_alias=True,
            exclude=excluded_fields,
            exclude_none=True,
        )
        # set to None if triangle_count (nullable) is None
        # and model_fields_set contains the field
        if self.triangle_count is None and "triangle_count" in self.model_fields_set:
            _dict['triangleCount'] = None

        # set to None if lod_hint (nullable) is None
        # and model_fields_set contains the field
        if self.lod_hint is None and "lod_hint" in self.model_fields_set:
            _dict['lodHint'] = None

        return _dict

    @classmethod
    def from_dict(cls, obj: Optional[Dict[str, Any]]) -> Optional[Self]:
        """Create an instance of FormatComplexity from a dict"""
        if obj is None:
            return None

        if not isinstance(obj, dict):
            return cls.model_validate(obj)

        _obj = cls.model_validate({
            "triangleCount": obj.get("triangleCount"),
            "lodHint": obj.get("lodHint")
        })
        return _obj


