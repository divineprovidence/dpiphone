// WARNING
// This file has been generated automatically by Xamarin Studio to
// mirror C# types. Changes in this file made by drag-connecting
// from the UI designer will be synchronized back to C#, but
// more complex manual changes may not transfer correctly.


#import <Foundation/Foundation.h>
#import <UIKit/UIKit.h>


@interface MainScreen : UIViewController {
	UIButton *__cmdAddJob;
	UIImageView *__imgLogo;
	UITableView *_ListJob;
}

@property (nonatomic, retain) IBOutlet UIButton *_cmdAddJob;

@property (nonatomic, retain) IBOutlet UIImageView *_imgLogo;

@property (nonatomic, retain) IBOutlet UITableView *ListJob;

- (IBAction)_AddJobBtnClicked:(id)sender;

@end
