using System;

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Html;

using R5T.T0132;


namespace R5T.F0086
{
	[FunctionalityMarker]
	public partial interface IRazorOperator : IFunctionalityMarker
	{
        public IHtmlContent GetHtmlContent(Func<object, IHtmlContent> lambda)
        {
            var htmlContent = lambda(null);
            return htmlContent;
        }

        public IHtmlContent GetHtmlContent<TModel>(Func<TModel, IHtmlContent> lambda, TModel model)
        {
            var htmlContent = lambda(model);
            return htmlContent;
        }

        /// <summary>
        /// Allows text (usually containing Razor markup) to be interpretted by the Razor engine as text.
        /// Useful for when you want to output Razor markup from the Razor engine.
        /// </summary>
        public MarkupString AsText(string text)
        {
            var output = new MarkupString(text);
            return output;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// The 'dynamic' type was chosen so that callsite can perform whatever operations the callsite believes to be appropriate (like @(item + 3) if the Razor implicit model is believed to be an integer, or @(item.Trim()) if a string).
        /// </remarks>
        public Func<dynamic, IHtmlContent> HtmlContent(Func<dynamic, IHtmlContent> lambda)
        {
            return lambda;
        }

        public Func<TModel, IHtmlContent> HtmlContent<TModel>(Func<TModel, IHtmlContent> lambda)
        {
            return lambda;
        }
    }
}