// WARNING
// This file has been generated automatically by Xamarin Studio to
// mirror C# types. Changes in this file made by drag-connecting
// from the UI designer will be synchronized back to C#, but
// more complex manual changes may not transfer correctly.


#import <Foundation/Foundation.h>
#import <UIKit/UIKit.h>


@interface AddJobScreen : UIViewController {
	UIButton *__addJobBtn;
	UITextView *__txtJobDescriptiobn;
	UITextField *__txtJobName;
	UITextField *__txtJobReward;
}

@property (nonatomic, retain) IBOutlet UIButton *_addJobBtn;

@property (nonatomic, retain) IBOutlet UITextView *_txtJobDescriptiobn;

@property (nonatomic, retain) IBOutlet UITextField *_txtJobName;

@property (nonatomic, retain) IBOutlet UITextField *_txtJobReward;

- (IBAction)AddJobBtnClicked:(id)sender;

@end
