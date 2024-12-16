/*
 * NinjaAPI
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using NUnit.Framework;

using Org.OpenAPITools.Client;
using Org.OpenAPITools.Api;
// uncomment below to import models
//using Org.OpenAPITools.Model;

namespace Org.OpenAPITools.Test.Api
{
    /// <summary>
    ///  Class for testing AssetsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class AssetsApiTests : IDisposable
    {
        private AssetsApi instance;

        public AssetsApiTests()
        {
            instance = new AssetsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of AssetsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' AssetsApi
            //Assert.IsType<AssetsApi>(instance);
        }

        /// <summary>
        /// Test IcosaApiAssetsDeleteAsset
        /// </summary>
        [Test]
        public void IcosaApiAssetsDeleteAssetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string asset = null;
            //var response = instance.IcosaApiAssetsDeleteAsset(asset);
            //Assert.IsType<int>(response);
        }

        /// <summary>
        /// Test IcosaApiAssetsGetAsset
        /// </summary>
        [Test]
        public void IcosaApiAssetsGetAssetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string asset = null;
            //var response = instance.IcosaApiAssetsGetAsset(asset);
            //Assert.IsType<AssetSchemaOut>(response);
        }

        /// <summary>
        /// Test IcosaApiAssetsGetAssets
        /// </summary>
        [Test]
        public void IcosaApiAssetsGetAssetsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string? category = null;
            //bool? curated = null;
            //List<string>? format = null;
            //string? keywords = null;
            //string? name = null;
            //string? description = null;
            //List<string>? tag = null;
            //string? orderBy = null;
            //string? orderBy2 = null;
            //Complexity? maxComplexity = null;
            //int? triangleCountMin = null;
            //int? triangleCountMax = null;
            //string? authorName = null;
            //string? authorName2 = null;
            //string? license = null;
            //string? pageToken = null;
            //string? pageToken2 = null;
            //string? pageSize = null;
            //string? pageSize2 = null;
            //var response = instance.IcosaApiAssetsGetAssets(category, curated, format, keywords, name, description, tag, orderBy, orderBy2, maxComplexity, triangleCountMin, triangleCountMax, authorName, authorName2, license, pageToken, pageToken2, pageSize, pageSize2);
            //Assert.IsType<PagedAssetSchemaOut>(response);
        }

        /// <summary>
        /// Test IcosaApiAssetsGetUserAsset
        /// </summary>
        [Test]
        public void IcosaApiAssetsGetUserAssetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string userurl = null;
            //string asseturl = null;
            //var response = instance.IcosaApiAssetsGetUserAsset(userurl, asseturl);
            //Assert.IsType<AssetSchemaOut>(response);
        }

        /// <summary>
        /// Test IcosaApiAssetsUnpublishAsset
        /// </summary>
        [Test]
        public void IcosaApiAssetsUnpublishAssetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int asset = null;
            //var response = instance.IcosaApiAssetsUnpublishAsset(asset);
            //Assert.IsType<AssetSchemaOut>(response);
        }
    }
}
