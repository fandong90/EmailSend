using System;

namespace Email.Toolkit
{
    /// <summary>
    /// Email template.
    /// </summary>
    public interface IEmailTemplate
    {
        string GetHtmlTemplate();
    }
}
