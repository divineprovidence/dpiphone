// WARNING
// This file has been generated automatically by Xamarin Studio to
// mirror C# types. Changes in this file made by drag-connecting
// from the UI designer will be synchronized back to C#, but
// more complex manual changes may not transfer correctly.


#import <Foundation/Foundation.h>
#import <UIKit/UIKit.h>


@interface LoginScreen : UIViewController {
	UIButton *__cmdJobView;
	UIButton *_cmdLogin;
	UIButton *_cmdRegister;
	UIImageView *_ImgLogoLogin;
	UITextField *_txtPassword;
	UITextField *_txtUserName;
}

@property (nonatomic, retain) IBOutlet UIButton *_cmdJobView;

@property (nonatomic, retain) IBOutlet UIButton *cmdLogin;

@property (nonatomic, retain) IBOutlet UIButton *cmdRegister;

@property (nonatomic, retain) IBOutlet UIImageView *ImgLogoLogin;

@property (nonatomic, retain) IBOutlet UITextField *txtPassword;

@property (nonatomic, retain) IBOutlet UITextField *txtUserName;

- (IBAction)ClickLogin:(id)sender;

- (IBAction)ClickEnterButton:(id)sender;

- (IBAction)JobViewClicked:(id)sender;

- (IBAction)ClickRegister:(id)sender;

@end
