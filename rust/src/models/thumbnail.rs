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
pub struct Thumbnail {
    #[serde(rename = "relativePath", default, with = "::serde_with::rust::double_option", skip_serializing_if = "Option::is_none")]
    pub relative_path: Option<Option<String>>,
    #[serde(rename = "contentType", default, with = "::serde_with::rust::double_option", skip_serializing_if = "Option::is_none")]
    pub content_type: Option<Option<String>>,
    #[serde(rename = "url", default, with = "::serde_with::rust::double_option", skip_serializing_if = "Option::is_none")]
    pub url: Option<Option<String>>,
}

impl Thumbnail {
    pub fn new() -> Thumbnail {
        Thumbnail {
            relative_path: None,
            content_type: None,
            url: None,
        }
    }
}

