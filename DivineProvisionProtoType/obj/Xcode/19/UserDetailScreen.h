// WARNING
// This file has been generated automatically by Xamarin Studio to
// mirror C# types. Changes in this file made by drag-connecting
// from the UI designer will be synchronized back to C#, but
// more complex manual changes may not transfer correctly.


#import <Foundation/Foundation.h>
#import <UIKit/UIKit.h>


@interface UserDetailScreen : UIViewController {
	UIButton *__cmdLocationDetails;
	UIImageView *__imgLogo;
	UITextField *__lblEmail;
	UITextField *__lblFirstName;
	UITextField *__lblLastName;
	UITextField *__lblLocation;
	UITextField *__lblUserName;
}

@property (nonatomic, retain) IBOutlet UIButton *_cmdLocationDetails;

@property (nonatomic, retain) IBOutlet UIImageView *_imgLogo;

@property (nonatomic, retain) IBOutlet UITextField *_lblEmail;

@property (nonatomic, retain) IBOutlet UITextField *_lblFirstName;

@property (nonatomic, retain) IBOutlet UITextField *_lblLastName;

@property (nonatomic, retain) IBOutlet UITextField *_lblLocation;

@property (nonatomic, retain) IBOutlet UITextField *_lblUserName;

- (IBAction)LocationDetailsClicked:(id)sender;

@end
