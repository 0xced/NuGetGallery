﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace NuGetGallery
{
    public class GalleryHomeViewModel
    {
        public bool ShowTransformModal { get; set; }

        public bool TransformIntoOrganization { get; set; }

        public string Identity { get; set; }

        public bool ShowEnable2FAModalFeatureEnabled { get; set; }

        public bool ShowDotnet20Banner { get; set; }

        public bool GetFeedbackOnModalDismissFeatureEnabled { get; set; }

        public GalleryHomeViewModel() : this(
            showTransformModal: false,
            transformIntoOrganization: false,
            showEnable2FAModalFeatureEnabled: false,
            getFeedbackOnModalDismiss: false,
            showDotnet20Banner: false,
            identity: null)
        { }

        public GalleryHomeViewModel(
            bool showTransformModal,
            bool transformIntoOrganization,
            bool showEnable2FAModalFeatureEnabled,
            bool getFeedbackOnModalDismiss,
            bool showDotnet20Banner,
            string identity = null)
        {
            ShowTransformModal = showTransformModal;
            TransformIntoOrganization = transformIntoOrganization;
            ShowEnable2FAModalFeatureEnabled = showEnable2FAModalFeatureEnabled;
            GetFeedbackOnModalDismissFeatureEnabled = getFeedbackOnModalDismiss;
            ShowDotnet20Banner = showDotnet20Banner;
            Identity = identity;
        }
    }
}