﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Azure.Devices.Provisioning.Service
{
    internal class SdkUtils
    {
        private const string ApiVersionProvisioning = "2021-11-01-preview";
        public const string ApiVersionQueryString = CustomHeaderConstants.ApiVersion + "=" + ApiVersionProvisioning;
    }
}
