Imports System
Imports Microsoft.AspNet.Identity
Imports Microsoft.AspNet.Identity.EntityFramework
Imports Microsoft.AspNet.Identity.Owin
Imports Microsoft.Owin
Imports Microsoft.Owin.Security.Cookies
Imports Microsoft.Owin.Security.DataProtection
Imports Microsoft.Owin.Security.Google
Imports Owin

Partial Public Class Startup

    ' 如需設定驗證的詳細資訊，請造訪 http://go.microsoft.com/fwlink/?LinkId=301883
    Public Sub ConfigureAuth(app As IAppBuilder)
        '設定 db 內容、使用者管理員和登入管理員以依要求使用單一執行個體
        app.CreatePerOwinContext(AddressOf ApplicationDbContext.Create)
        app.CreatePerOwinContext(Of ApplicationUserManager)(AddressOf ApplicationUserManager.Create)
        app.CreatePerOwinContext(Of ApplicationSignInManager)(AddressOf ApplicationSignInManager.Create)

        ' 啟用應用程式以使用 Cookie 來儲存已登入使用者的資訊
        app.UseCookieAuthentication(New CookieAuthenticationOptions() With {
            .AuthenticationType = DefaultAuthenticationTypes.ApplicationCookie,
            .Provider = New CookieAuthenticationProvider() With {
                .OnValidateIdentity = SecurityStampValidator.OnValidateIdentity(Of ApplicationUserManager, ApplicationUser)(
                    validateInterval:=TimeSpan.FromMinutes(30),
                    regenerateIdentity:=Function(manager, user) user.GenerateUserIdentityAsync(manager))},
            .LoginPath = New PathString("/Account/Login")})
        ' 使用 Cookie 暫時儲存使用者利用協力廠商登入提供者登入的相關資訊
        app.UseExternalSignInCookie(DefaultAuthenticationTypes.ExternalCookie)

        ' 在雙因素驗證程序中驗證第二個因素時，啟用應用程式以暫時儲存使用者資訊。
        app.UseTwoFactorSignInCookie(DefaultAuthenticationTypes.TwoFactorCookie, TimeSpan.FromMinutes(5))

        ' 啟用應用程式以記住第二個登入驗證因素，例如電話或電子郵件。
        ' 一旦您勾選此選項，您在登入程序中的第二個驗證步驟會在您用來登入的裝置上記住。
        ' 這類似於您登入時的 RememberMe 選項。
        app.UseTwoFactorRememberBrowserCookie(DefaultAuthenticationTypes.TwoFactorRememberBrowserCookie)

        ' 取消註解下列行以啟用透過第三方登入提供者的登入
        'app.UseMicrosoftAccountAuthentication(
        '    clientId:= "",
        '    clientSecret:= "")

        'app.UseTwitterAuthentication(
        '   consumerKey:= "",
        '   consumerSecret:= "")

        'app.UseFacebookAuthentication(
        '   appId:= "",
        '   appSecret:= "")

        'app.UseGoogleAuthentication(New GoogleOAuth2AuthenticationOptions() With {
        '   .ClientId = "",
        '   .ClientSecret = ""})
    End Sub
End Class
