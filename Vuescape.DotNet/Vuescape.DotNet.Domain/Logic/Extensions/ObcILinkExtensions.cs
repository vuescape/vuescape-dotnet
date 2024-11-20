// <copyright file="ObcILinkExtensions.Internal.cs" company="Vuescape">
//    Copyright (c) Vuescape 2021. All rights reserved.
// </copyright>

// ReSharper disable once CheckNamespace
namespace Vuescape.DotNet.Domain
{
    using System;

    using OBeautifulCode.Assertion.Recipes;
    using OBeautifulCode.DataStructure;

    using static System.FormattableString;

    /// <summary>
    /// Extension methods on <see cref="OBeautifulCode.DataStructure.ICell"/>.
    /// </summary>
    public static partial class ObcILinkExtensions
    {
        /// <summary>
        /// Convert an <see cref="ILink"/> to a <see cref="Link"/>.
        /// </summary>
        /// <param name="link">The link.</param>
        /// <param name="obcToVuescapeConversionContext">The conversion context.</param>
        /// <returns>A <see cref="TreeTableCell"/>.</returns>
        internal static Link ToVuescapeLink(
            this ILink link,
            ObcToVuescapeConversionContext obcToVuescapeConversionContext)
        {
            new { link }.Must().NotBeNull();

            Link result = null;

            if (link is StandardLink standardLink)
            {
                var linkTarget = standardLink.Target.GetLinkTarget();
                if (standardLink.Resource is UrlLinkedResource urlLinkedResource)
                {
                    var resourceKind = GetResourceKind(urlLinkedResource.ResourceKind);
                    var resource = urlLinkedResource.Url;
                    if (!string.IsNullOrWhiteSpace(obcToVuescapeConversionContext.BaseUrl))
                    {
                        // TODO: Use URL builder
                        resource = resource.Replace(obcToVuescapeConversionContext.BaseUrlToken, obcToVuescapeConversionContext.BaseUrl);
                    }

                    result = new Link(resource, linkTarget, null, null, resourceKind);
                }
                else
                {
                    if (obcToVuescapeConversionContext?.ReportConversionMode == ReportConversionMode.Strict)
                    {
                        throw new InvalidOperationException(Invariant(
                            $"Only {nameof(ILinkedResource)} of type {nameof(UrlLinkedResource)} is supported. {standardLink.Resource.GetType().Name} is not supported."));
                    }
                }
            }
            else
            {
                if (obcToVuescapeConversionContext?.ReportConversionMode == ReportConversionMode.Strict)
                {
                    throw new InvalidOperationException(Invariant(
                        $"Only type {nameof(StandardLink)} is supported {nameof(ILink)} type. {link.GetType().Name} is not supported."));
                }
            }

            return result;
        }

        private static ResourceKind GetResourceKind(
            this OBeautifulCode.DataStructure.UrlLinkedResourceKind urlLinkedResourceKind)
        {
            switch (urlLinkedResourceKind)
            {
                case UrlLinkedResourceKind.Unknown:
                    return ResourceKind.Unknown;
                case UrlLinkedResourceKind.Report:
                    return ResourceKind.Report;
                case UrlLinkedResourceKind.Json:
                    return ResourceKind.Json;
                case UrlLinkedResourceKind.Image:
                    return ResourceKind.Image;
                case UrlLinkedResourceKind.Audio:
                    return ResourceKind.Audio;
                case UrlLinkedResourceKind.Video:
                    return ResourceKind.Video;
                case UrlLinkedResourceKind.Html:
                    return ResourceKind.Html;
                case UrlLinkedResourceKind.Excel:
                    return ResourceKind.Excel;
                case UrlLinkedResourceKind.Csv:
                    return ResourceKind.Csv;
                case UrlLinkedResourceKind.Pdf:
                    return ResourceKind.Pdf;
                default:
                    throw new ArgumentOutOfRangeException(nameof(urlLinkedResourceKind), urlLinkedResourceKind, null);
            }
        }

        private static LinkTarget GetLinkTarget(
            this OBeautifulCode.DataStructure.LinkTarget? linkTarget)
        {
            switch (linkTarget)
            {
                case OBeautifulCode.DataStructure.LinkTarget.CenterPane:
                    return LinkTarget.CenterPane;
                case OBeautifulCode.DataStructure.LinkTarget.Unknown:
                    return LinkTarget.None;
                case OBeautifulCode.DataStructure.LinkTarget.CurrentPane:
                    return LinkTarget.CenterPane;
                case OBeautifulCode.DataStructure.LinkTarget.LeftPane:
                    return LinkTarget.LeftPane;
                case OBeautifulCode.DataStructure.LinkTarget.RightPane:
                    return LinkTarget.RightPane;
                case OBeautifulCode.DataStructure.LinkTarget.CurrentWindow:
                    return LinkTarget.CurrentWindow;
                case OBeautifulCode.DataStructure.LinkTarget.NewWindow:
                    return LinkTarget.NewWindow;
                case OBeautifulCode.DataStructure.LinkTarget.Download:
                    return LinkTarget.Download;
                case OBeautifulCode.DataStructure.LinkTarget.Modal:
                    return LinkTarget.Modal;
                default:
                    return LinkTarget.None;
            }
        }
    }
}