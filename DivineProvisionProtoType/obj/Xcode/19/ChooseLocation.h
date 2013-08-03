// WARNING
// This file has been generated automatically by Xamarin Studio to
// mirror C# types. Changes in this file made by drag-connecting
// from the UI designer will be synchronized back to C#, but
// more complex manual changes may not transfer correctly.


#import <Foundation/Foundation.h>
#import <UIKit/UIKit.h>


@interface ChooseLocation : UIViewController {
    UIButton *_cmdAddNewLocation;
    UITableView *_listExistingLocations;
    
    
}
@property (retain, nonatomic) IBOutlet UIButton *_cmdAddNewLocation;
@property (retain, nonatomic) IBOutlet UITableView *_listExistingLocations;
- (IBAction)AddNewLocationClicked:(id)sender;

@end
