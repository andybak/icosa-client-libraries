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
pub struct AssetResource {
    #[serde(rename = "relativePath")]
    pub relative_path: String,
    #[serde(rename = "contentType")]
    pub content_type: String,
    #[serde(rename = "url")]
    pub url: String,
}

impl AssetResource {
    pub fn new(relative_path: String, content_type: String, url: String) -> AssetResource {
        AssetResource {
            relative_path,
            content_type,
            url,
        }
    }
}

