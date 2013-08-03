// WARNING
// This file has been generated automatically by Xamarin Studio to
// mirror C# types. Changes in this file made by drag-connecting
// from the UI designer will be synchronized back to C#, but
// more complex manual changes may not transfer correctly.


#import <Foundation/Foundation.h>
#import <UIKit/UIKit.h>


@interface RegisterUser : UIViewController {
	UIButton *__cmdJobListView;
	UIButton *__cmdRegisterUser;
	UIImageView *__imgLogo;
	UITextField *__txtEmail;
	UITextField *__txtFirstName;
	UITextField *__txtLastName;
	UITextField *__txtPassword;
	UITextField *__txtUserName;
}

@property (nonatomic, retain) IBOutlet UIButton *_cmdJobListView;

@property (nonatomic, retain) IBOutlet UIButton *_cmdRegisterUser;

@property (nonatomic, retain) IBOutlet UIImageView *_imgLogo;

@property (nonatomic, retain) IBOutlet UITextField *_txtEmail;

@property (nonatomic, retain) IBOutlet UITextField *_txtFirstName;

@property (nonatomic, retain) IBOutlet UITextField *_txtLastName;

@property (nonatomic, retain) IBOutlet UITextField *_txtPassword;

@property (nonatomic, retain) IBOutlet UITextField *_txtUserName;

- (IBAction)RegisterUserClicked:(id)sender;

- (IBAction)JobViewClicked:(id)sender;

@end
