// WARNING
// This file has been generated automatically by Xamarin Studio to
// mirror C# types. Changes in this file made by drag-connecting
// from the UI designer will be synchronized back to C#, but
// more complex manual changes may not transfer correctly.


#import "RegisterUser.h"

@implementation RegisterUser

@synthesize _cmdJobListView;
@synthesize _cmdRegisterUser = __cmdRegisterUser;
@synthesize _imgLogo = __imgLogo;
@synthesize _txtEmail = __txtEmail;
@synthesize _txtPassword = __txtPassword;
@synthesize _txtUserName = __txtUserName;
@synthesize _txtFirstName;
@synthesize _txtLastName;

- (IBAction)RegisterUserClicked:(id)sender {
}

- (void)dealloc {
    [_txtFirstName release];
    [_txtLastName release];
    [_cmdJobListView release];
    [super dealloc];
}
- (void)viewDidUnload {
    [self set_txtFirstName:nil];
    [self set_txtLastName:nil];
    [self set_cmdJobListView:nil];
    [super viewDidUnload];
}
- (IBAction)JobViewClicked:(id)sender {
}
@end
