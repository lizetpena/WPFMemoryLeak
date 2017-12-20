This solution is a very academic example showcasing a memory increase in the heap. The solution contains a WPF project with three xaml screens. The main screen has 4 buttons.
 The "Add Item" button adds a Customer to an observable collection that is bound to a UI List
 The DataMonitor screen shows the count of the collection items when a new item is added to removed from the collection of customers.
 The DataMonitor.xaml.cs class has an array _dataLeaked and a List _dataLeaked2 that grow in size every time a new Customer is added or removed on the ObservableCollection\
 The purpose of this example is to showcase the diagnostic and performance tools that come with Visual Studio 2017.
 
 This example does not have a proper separation between the models and the views, does not use ViewModels and it isn't meant to demostrate the MVVM pattern. For enterprise applications, the MVVM pattern is the best approach to follow when building desktop applications with WPF.
