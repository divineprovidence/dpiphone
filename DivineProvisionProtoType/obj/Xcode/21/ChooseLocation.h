// WARNING
// This file has been generated automatically by Xamarin Studio to
// mirror C# types. Changes in this file made by drag-connecting
// from the UI designer will be synchronized back to C#, but
// more complex manual changes may not transfer correctly.


#import <Foundation/Foundation.h>
#import <UIKit/UIKit.h>


@interface ChooseLocation : UIViewController {
	UIButton *__cmdAddNewLocation;
	UITableView *__listExistingLocations;
}

@property (nonatomic, retain) IBOutlet UIButton *_cmdAddNewLocation;

@property (nonatomic, retain) IBOutlet UITableView *_listExistingLocations;

- (IBAction)AddNewLocationClicked:(id)sender;

@end
