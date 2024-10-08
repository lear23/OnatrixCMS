//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder.Embedded v14.2.0+1b21caa
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Linq.Expressions;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Core.PublishedCache;
using Umbraco.Cms.Infrastructure.ModelsBuilder;
using Umbraco.Cms.Core;
using Umbraco.Extensions;

namespace Umbraco.Cms.Web.Common.PublishedModels
{
	/// <summary>About Us Page</summary>
	[PublishedModel("aboutUsPage")]
	public partial class AboutUsPage : PublishedContentModel
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		public new const string ModelTypeAlias = "aboutUsPage";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public new static IPublishedContentType GetModelContentType(IPublishedSnapshotAccessor publishedSnapshotAccessor)
			=> PublishedModelUtility.GetModelContentType(publishedSnapshotAccessor, ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(IPublishedSnapshotAccessor publishedSnapshotAccessor, Expression<Func<AboutUsPage, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(publishedSnapshotAccessor), selector);
#pragma warning restore 0109

		private IPublishedValueFallback _publishedValueFallback;

		// ctor
		public AboutUsPage(IPublishedContent content, IPublishedValueFallback publishedValueFallback)
			: base(content, publishedValueFallback)
		{
			_publishedValueFallback = publishedValueFallback;
		}

		// properties

		///<summary>
		/// About Page - img
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("aboutPageImg")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops AboutPageImg => this.Value<global::Umbraco.Cms.Core.Models.MediaWithCrops>(_publishedValueFallback, "aboutPageImg");

		///<summary>
		/// About page - Quote
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("aboutPageQuote")]
		public virtual string AboutPageQuote => this.Value<string>(_publishedValueFallback, "aboutPageQuote");

		///<summary>
		/// About Page - Text
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("aboutPageText")]
		public virtual string AboutPageText => this.Value<string>(_publishedValueFallback, "aboutPageText");

		///<summary>
		/// About us - Text  
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("aboutUsText")]
		public virtual string AboutUsText => this.Value<string>(_publishedValueFallback, "aboutUsText");

		///<summary>
		/// Our Expert section - cardImg
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("ourExpertSectionCardImg")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops OurExpertSectionCardImg => this.Value<global::Umbraco.Cms.Core.Models.MediaWithCrops>(_publishedValueFallback, "ourExpertSectionCardImg");

		///<summary>
		/// Our Expert section - cardImg2
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("ourExpertSectionCardImg2")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops OurExpertSectionCardImg2 => this.Value<global::Umbraco.Cms.Core.Models.MediaWithCrops>(_publishedValueFallback, "ourExpertSectionCardImg2");

		///<summary>
		/// Our Expert section - cardImg3
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("ourExpertSectionCardImg3")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops OurExpertSectionCardImg3 => this.Value<global::Umbraco.Cms.Core.Models.MediaWithCrops>(_publishedValueFallback, "ourExpertSectionCardImg3");

		///<summary>
		/// Our Expert section - cardImg4
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("ourExpertSectionCardImg4")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops OurExpertSectionCardImg4 => this.Value<global::Umbraco.Cms.Core.Models.MediaWithCrops>(_publishedValueFallback, "ourExpertSectionCardImg4");

		///<summary>
		/// Our Expert section - cardImg5
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("ourExpertSectionCardImg5")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops OurExpertSectionCardImg5 => this.Value<global::Umbraco.Cms.Core.Models.MediaWithCrops>(_publishedValueFallback, "ourExpertSectionCardImg5");

		///<summary>
		/// Our Expert section - cardImg6
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("ourExpertSectionCardImg6")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops OurExpertSectionCardImg6 => this.Value<global::Umbraco.Cms.Core.Models.MediaWithCrops>(_publishedValueFallback, "ourExpertSectionCardImg6");

		///<summary>
		/// Our Expert section - cardImg7
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("ourExpertSectionCardImg7")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops OurExpertSectionCardImg7 => this.Value<global::Umbraco.Cms.Core.Models.MediaWithCrops>(_publishedValueFallback, "ourExpertSectionCardImg7");

		///<summary>
		/// Our Expert section - cardP
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("ourExpertSectionCardP")]
		public virtual string OurExpertSectionCardP => this.Value<string>(_publishedValueFallback, "ourExpertSectionCardP");

		///<summary>
		/// Our Expert section - cardP2
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("ourExpertSectionCardP2")]
		public virtual string OurExpertSectionCardP2 => this.Value<string>(_publishedValueFallback, "ourExpertSectionCardP2");

		///<summary>
		/// Our Expert section - cardP3
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("ourExpertSectionCardP3")]
		public virtual string OurExpertSectionCardP3 => this.Value<string>(_publishedValueFallback, "ourExpertSectionCardP3");

		///<summary>
		/// Our Expert section - cardP4
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("ourExpertSectionCardP4")]
		public virtual string OurExpertSectionCardP4 => this.Value<string>(_publishedValueFallback, "ourExpertSectionCardP4");

		///<summary>
		/// Our Expert section - cardP5
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("ourExpertSectionCardP5")]
		public virtual string OurExpertSectionCardP5 => this.Value<string>(_publishedValueFallback, "ourExpertSectionCardP5");

		///<summary>
		/// Our Expert section - cardP6
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("ourExpertSectionCardP6")]
		public virtual string OurExpertSectionCardP6 => this.Value<string>(_publishedValueFallback, "ourExpertSectionCardP6");

		///<summary>
		/// Our Expert section - cardP7
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("ourExpertSectionCardP7")]
		public virtual string OurExpertSectionCardP7 => this.Value<string>(_publishedValueFallback, "ourExpertSectionCardP7");

		///<summary>
		/// Our Expert section - cardSpan
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("ourExpertSectionCardSpan")]
		public virtual string OurExpertSectionCardSpan => this.Value<string>(_publishedValueFallback, "ourExpertSectionCardSpan");

		///<summary>
		/// Our Expert section - cardSpan2
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("ourExpertSectionCardSpan2")]
		public virtual string OurExpertSectionCardSpan2 => this.Value<string>(_publishedValueFallback, "ourExpertSectionCardSpan2");

		///<summary>
		/// Our Expert section - cardSpan3
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("ourExpertSectionCardSpan3")]
		public virtual string OurExpertSectionCardSpan3 => this.Value<string>(_publishedValueFallback, "ourExpertSectionCardSpan3");

		///<summary>
		/// Our Expert section - cardSpan4
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("ourExpertSectionCardSpan4")]
		public virtual string OurExpertSectionCardSpan4 => this.Value<string>(_publishedValueFallback, "ourExpertSectionCardSpan4");

		///<summary>
		/// Our Expert section - cardSpan5
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("ourExpertSectionCardSpan5")]
		public virtual string OurExpertSectionCardSpan5 => this.Value<string>(_publishedValueFallback, "ourExpertSectionCardSpan5");

		///<summary>
		/// Our Expert section - cardSpan6
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("ourExpertSectionCardSpan6")]
		public virtual string OurExpertSectionCardSpan6 => this.Value<string>(_publishedValueFallback, "ourExpertSectionCardSpan6");

		///<summary>
		/// Our Expert section - cardSpan7
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("ourExpertSectionCardSpan7")]
		public virtual string OurExpertSectionCardSpan7 => this.Value<string>(_publishedValueFallback, "ourExpertSectionCardSpan7");

		///<summary>
		/// Our Expert section - h1
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("ourExpertSectionH1")]
		public virtual string OurExpertSectionH1 => this.Value<string>(_publishedValueFallback, "ourExpertSectionH1");

		///<summary>
		/// Our Expert section - h3
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("ourExpertSectionH3")]
		public virtual string OurExpertSectionH3 => this.Value<string>(_publishedValueFallback, "ourExpertSectionH3");

		///<summary>
		/// Page Title
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("pageTitle")]
		public virtual string PageTitle => this.Value<string>(_publishedValueFallback, "pageTitle");

		///<summary>
		/// reviews section -bgImg
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("reviewsSectionBgImg")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops ReviewsSectionBgImg => this.Value<global::Umbraco.Cms.Core.Models.MediaWithCrops>(_publishedValueFallback, "reviewsSectionBgImg");

		///<summary>
		/// reviews section -h1
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("reviewsSectionH1")]
		public virtual string ReviewsSectionH1 => this.Value<string>(_publishedValueFallback, "reviewsSectionH1");

		///<summary>
		/// reviews section - h4
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("reviewsSectionH4")]
		public virtual string ReviewsSectionH4 => this.Value<string>(_publishedValueFallback, "reviewsSectionH4");

		///<summary>
		/// reviews section -h5
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("reviewsSectionH5")]
		public virtual string ReviewsSectionH5 => this.Value<string>(_publishedValueFallback, "reviewsSectionH5");

		///<summary>
		/// reviews section - img
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("reviewsSectionImg")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops ReviewsSectionImg => this.Value<global::Umbraco.Cms.Core.Models.MediaWithCrops>(_publishedValueFallback, "reviewsSectionImg");

		///<summary>
		/// reviews section - p
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("reviewsSectionP")]
		public virtual string ReviewsSectionP => this.Value<string>(_publishedValueFallback, "reviewsSectionP");

		///<summary>
		/// reviews section - Swebank
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("reviewsSectionSwebank")]
		public virtual string ReviewsSectionSwebank => this.Value<string>(_publishedValueFallback, "reviewsSectionSwebank");
	}
}
