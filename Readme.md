This solution is a very academic example showcasing a memory increase in the heap that can result in an OutOfMemory Exception. 
 The solution contains a WPF project with three XAML screens and a few buttons. 
 -The "Add Item" button adds a Customer to an observable collection that is bound to a UI List.
 -The DataMonitor button shows in a XAML View the count of the collection items (Customers) whenever a new item is added to, or removed from, the collection of customers.
 - The DataMonitor.xaml.cs class has an array _dataLeaked, and a List _dataLeaked2 that grows in size every time a new Customer is added or removed on the ObservableCollection.
 
 The purpose of this example is to showcase the Diagnostic and Performance tools including the Diagnostic Windows in Visual Studio 2017.
 
 This example does not have a proper separation between the models and the views, does not use ViewModels and it isn't meant to demostrate the MVVM pattern. 
 For enterprise applications, the MVVM pattern is the best approach to follow when building desktop applications with WPF.
