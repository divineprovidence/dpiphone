// WARNING
// This file has been generated automatically by Xamarin Studio to
// mirror C# types. Changes in this file made by drag-connecting
// from the UI designer will be synchronized back to C#, but
// more complex manual changes may not transfer correctly.


#import <Foundation/Foundation.h>
#import <UIKit/UIKit.h>


@interface JobDetailScreen : UIViewController {
	UIButton *__cmdUserPostingButton;
	UIImageView *__imgJobLogo;
	UIImageView *__imgMemberPicture;
	UITextView *__lblJobDescription;
	UILabel *__lblJobName;
	UIImageView *__lblJobUserPostingImage;
	UILabel *__lblJobUserPostingUserName;
	UILabel *__lblMemberUserName;
	UITableView *__listJobBid;
}

@property (nonatomic, retain) IBOutlet UIButton *_cmdUserPostingButton;

@property (nonatomic, retain) IBOutlet UIImageView *_imgJobLogo;

@property (nonatomic, retain) IBOutlet UIImageView *_imgMemberPicture;

@property (nonatomic, retain) IBOutlet UITextView *_lblJobDescription;

@property (nonatomic, retain) IBOutlet UILabel *_lblJobName;

@property (nonatomic, retain) IBOutlet UIImageView *_lblJobUserPostingImage;

@property (nonatomic, retain) IBOutlet UILabel *_lblJobUserPostingUserName;

@property (nonatomic, retain) IBOutlet UILabel *_lblMemberUserName;

@property (nonatomic, retain) IBOutlet UITableView *_listJobBid;

- (IBAction)UserPostingClick:(id)sender;

@end
