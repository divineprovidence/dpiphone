// WARNING
// This file has been generated automatically by Xamarin Studio to
// mirror C# types. Changes in this file made by drag-connecting
// from the UI designer will be synchronized back to C#, but
// more complex manual changes may not transfer correctly.


#import <Foundation/Foundation.h>
#import <UIKit/UIKit.h>


@interface AddLocationScreeen : UIViewController {
	UIButton *__cmdAddLocation;
	UITextField *__txtLocationCity;
	UITextField *__txtLocationCountry;
	UITextField *__txtLocationGeoCode;
	UITextField *__txtLocationName;
}

@property (nonatomic, retain) IBOutlet UIButton *_cmdAddLocation;

@property (nonatomic, retain) IBOutlet UITextField *_txtLocationCity;

@property (nonatomic, retain) IBOutlet UITextField *_txtLocationCountry;

@property (nonatomic, retain) IBOutlet UITextField *_txtLocationGeoCode;

@property (nonatomic, retain) IBOutlet UITextField *_txtLocationName;

- (IBAction)AddLocationBtnClicked:(id)sender;

@end
