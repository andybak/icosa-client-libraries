/*
 * NinjaAPI
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.0.0
 * 
 * Generated by: https://openapi-generator.tech
 */

use crate::models;
use serde::{Deserialize, Serialize};

#[derive(Clone, Default, Debug, PartialEq, Serialize, Deserialize)]
pub struct FormatComplexity {
    #[serde(rename = "triangleCount", default, with = "::serde_with::rust::double_option", skip_serializing_if = "Option::is_none")]
    pub triangle_count: Option<Option<i32>>,
    #[serde(rename = "lodHint", default, with = "::serde_with::rust::double_option", skip_serializing_if = "Option::is_none")]
    pub lod_hint: Option<Option<i32>>,
}

impl FormatComplexity {
    pub fn new() -> FormatComplexity {
        FormatComplexity {
            triangle_count: None,
            lod_hint: None,
        }
    }
}
