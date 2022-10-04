Feature: ConfirmingOrder

A short summary of the feature

@tag1
Scenario: Confirming Order Page
	Given  Navigate to the Website
	When   Click on Buy Now of Margerita 
	Then   Cart Page Opens
	When Click on Continue Shopping
	Then Home Page Opens
	When Click on Buy Now of Corn
	Then Cart Page Opens Again
	When Click on CheckOut
	Then Order Confirmation Page Opens