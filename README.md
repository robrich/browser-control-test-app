Browser Control Test App
========================

This application tests the embedded browser in both the old and new browser controls in Windows Forms on .NET Framework.

Usage
-----

1. In Visual Studio, load the solution, restore NuGet packages, build the project, and run it.

2. The top half is the old `System.Windows.Forms.WebBrowser`. The bottom half is the new `Microsoft.Web.WebView2.WinForms.WebView2` control. Above each is a text box and a navigate button. You can imagine these as browser navigation controls.

3. Type a web address in the top text box at the top such as `https://www.whatismybrowser.com/` and push the Navigate button. The resulting page is displayed. (You may get JavaScript errors. Spoiler: it's Internet Explorer 11.)

4. Type a web address in the text box in the middle of the page such as `https://www.whatismybrowser.com/` and push the Navigate button. The resulting page is displayed.

5. In each browser, navigate to a page that shows details about your browser such as:

   - https://www.whatismybrowser.com/
   - https://detectmybrowser.com/
   - https://www.whatsmybrowser.org/

6. Enjoy!

References
----------

- Details about the new browser control: https://docs.microsoft.com/en-us/microsoft-edge/webview2/get-started/winforms

- Details about the old browser control: https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.webbrowser?view=windowsdesktop-6.0

- Details about Internet Explorer's deprecation: https://docs.microsoft.com/en-us/lifecycle/announcements/internet-explorer-11-end-of-support

- Microsoft 365 says farewell to Internet Explorer: https://techcommunity.microsoft.com/t5/microsoft-365-blog/microsoft-365-apps-say-farewell-to-internet-explorer-11-and/ba-p/1591666

- Internet Explorer 11's lifecycle policy: https://docs.microsoft.com/en-us/lifecycle/faq/internet-explorer-microsoft-edge

- An answered question about Internet Explorer and the WebBrowser control: https://docs.microsoft.com/en-us/answers/questions/159839/regarding-support-for-iwebbrowser2.html

License
-------

MIT
