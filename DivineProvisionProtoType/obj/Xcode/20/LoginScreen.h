// WARNING
// This file has been generated automatically by Xamarin Studio to
// mirror C# types. Changes in this file made by drag-connecting
// from the UI designer will be synchronized back to C#, but
// more complex manual changes may not transfer correctly.


#import <Foundation/Foundation.h>
#import <UIKit/UIKit.h>


@interface LoginScreen : UIViewController {
	UIButton *_cmdLogin;
	UIButton *_cmdRegister;
	UIImageView *_ImgLogoLogin;
	UITextField *_txtPassword;
	UITextField *_txtUserName;
    UIButton *_cmdJobView;
}

@property (nonatomic, retain) IBOutlet UIButton *cmdLogin;
@property (retain, nonatomic) IBOutlet UIButton *_cmdJobView;

@property (nonatomic, retain) IBOutlet UIButton *cmdRegister;
- (IBAction)JobViewClicked:(id)sender;

@property (nonatomic, retain) IBOutlet UIImageView *ImgLogoLogin;

@property (nonatomic, retain) IBOutlet UITextField *txtPassword;

@property (nonatomic, retain) IBOutlet UITextField *txtUserName;

- (IBAction)ClickLogin:(id)sender;

- (IBAction)ClickEnterButton:(id)sender;

- (IBAction)ClickRegister:(id)sender;

@end
