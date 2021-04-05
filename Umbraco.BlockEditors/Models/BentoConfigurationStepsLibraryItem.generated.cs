//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder.Embedded v8.12.2
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Web;
using Umbraco.Core.Models;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;
using Umbraco.ModelsBuilder.Embedded;

namespace Umbraco.Web.PublishedModels
{
	/// <summary>Bento Configuration Steps Library Item</summary>
	[PublishedModel("bentoConfigurationStepsLibraryItem")]
	public partial class BentoConfigurationStepsLibraryItem : PublishedContentModel, IBentoConfigurationStepsComposition, IBentoItem
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.12.2")]
		public new const string ModelTypeAlias = "bentoConfigurationStepsLibraryItem";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.12.2")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.12.2")]
		public new static IPublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.12.2")]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<BentoConfigurationStepsLibraryItem, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public BentoConfigurationStepsLibraryItem(IPublishedContent content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// Configuration Steps
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.12.2")]
		[ImplementPropertyType("configurationSteps")]
		public global::System.Collections.Generic.IEnumerable<global::Umbraco.Web.PublishedModels.ConfigurationStepBlock> ConfigurationSteps => global::Umbraco.Web.PublishedModels.BentoConfigurationStepsComposition.GetConfigurationSteps(this);

		///<summary>
		/// Finish Step Text
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.12.2")]
		[ImplementPropertyType("finishStepText")]
		public string FinishStepText => global::Umbraco.Web.PublishedModels.BentoConfigurationStepsComposition.GetFinishStepText(this);

		///<summary>
		/// Heading
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.12.2")]
		[ImplementPropertyType("heading")]
		public string Heading => global::Umbraco.Web.PublishedModels.BentoConfigurationStepsComposition.GetHeading(this);

		///<summary>
		/// Sub Heading
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.12.2")]
		[ImplementPropertyType("subHeading")]
		public string SubHeading => global::Umbraco.Web.PublishedModels.BentoConfigurationStepsComposition.GetSubHeading(this);
	}
}
