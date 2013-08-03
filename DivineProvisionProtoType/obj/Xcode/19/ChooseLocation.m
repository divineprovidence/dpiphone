// WARNING
// This file has been generated automatically by Xamarin Studio to
// mirror C# types. Changes in this file made by drag-connecting
// from the UI designer will be synchronized back to C#, but
// more complex manual changes may not transfer correctly.


#import "ChooseLocation.h"

@implementation ChooseLocation
@synthesize _cmdAddNewLocation;
@synthesize _listExistingLocations;

- (void)dealloc {
    [_cmdAddNewLocation release];
    [_listExistingLocations release];
    [super dealloc];
}
- (void)viewDidUnload {
    [self set_cmdAddNewLocation:nil];
    [self set_listExistingLocations:nil];
    [super viewDidUnload];
}
- (IBAction)AddNewLocationClicked:(id)sender {
}
@end
