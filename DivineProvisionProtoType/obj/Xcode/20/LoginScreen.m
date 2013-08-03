// WARNING
// This file has been generated automatically by Xamarin Studio to
// mirror C# types. Changes in this file made by drag-connecting
// from the UI designer will be synchronized back to C#, but
// more complex manual changes may not transfer correctly.


#import "LoginScreen.h"

@implementation LoginScreen

@synthesize cmdLogin = _cmdLogin;
@synthesize _cmdJobView;
@synthesize cmdRegister = _cmdRegister;
@synthesize ImgLogoLogin = _ImgLogoLogin;
@synthesize txtPassword = _txtPassword;
@synthesize txtUserName = _txtUserName;

- (IBAction)ClickLogin:(id)sender {
}

- (IBAction)ClickEnterButton:(id)sender {
}

- (IBAction)ClickRegister:(id)sender {
}

- (void)dealloc {
    [_cmdJobView release];
    [super dealloc];
}
- (void)viewDidUnload {
    [self set_cmdJobView:nil];
    [super viewDidUnload];
}
- (IBAction)JobViewClicked:(id)sender {
}
@end
