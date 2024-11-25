using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace TaskManagement.Helpers
{
    public static class HtmlHelpers
    {
        public static string GetEnumDisplayName<TEnum>(this IHtmlHelper htmlHelper, TEnum enumValue) where TEnum : Enum
        {
            var displayAttribute = enumValue.GetType()
                .GetMember(enumValue.ToString())
                .FirstOrDefault()
                ?.GetCustomAttribute<DisplayAttribute>();

            return displayAttribute?.GetName() ?? enumValue.ToString();
        }
    }
}
