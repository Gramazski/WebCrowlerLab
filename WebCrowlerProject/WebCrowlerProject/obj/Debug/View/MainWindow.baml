   M S B A M L   `   `   `  ����L  HWebCrowlerProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:WebCrowlerProject.ViewModelWebCrowlerProject.ViewModel  5   	   _4clr-namespace:WebCrowlerProject.CrawlResultConverter&WebCrowlerProject.CrawlResultConverter  5   	   5clr-namespace:WebCrowlerProjectWebCrowlerProject  5   	   "    WebCrowlerProject.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ?	viewModel)clr-namespace:WebCrowlerProject.ViewModel     5   	   J	converter4clr-namespace:WebCrowlerProject.CrawlResultConverter     5   	   1localclr-namespace:WebCrowlerProject     5   	     � Title$  
WebCrowler��5
   	   $	��450��6   $	��630��6)    � 	Resources 5      5  /WebCrowlerProject.ViewModel.WebCrowlerViewModel   	ViewModel<  6WebCrowlerProject.CrawlResultConverter.ResultConverter  	Converter��%:   &	        &	        5   
   6(     5   
   6$   5      .��5      � $
��Left=�6   $	��450��6&   $	��Top=�63   $	��630��6K   .+�5   
   R� -   5         R�Name$ UrlTreeView��5      $
��Left=�6(   $	��310��6C   $	��Top=�6P   $	��610��6h   $��0,0,0,0q�6t   ��5      �� *WebCrawlResult+ �� 	Converter# [  �� Source# [  �� 5   
   -   5         ��Name$ crowlerStartButton��5      $��Start crawl��6-   $
��Left=�6D   $��535,357,0,0q�6_   $	��Top=�6t   $��75��6�   ��6�   �� *	Command+# [  �� 5   
   -   5         ��Name$ counterTextBox��5      $
��Left=�6*   $��23��6E   $��
10,357,0,0q�6Q    �� TextWrapping$
 Wrap=�6e   $��Counter checking textbox��6y   $	��Top=�6�   $	��369��6�   �� 5   
   -   5        $ incrementButton��5      $��	Increment��6*   $
��Left=�6>   $��394,357,0,0q�6Y   $	��Top=�6n   $��75��6�   6�   5      5      