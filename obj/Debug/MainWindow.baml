   M S B A M L   `   `   `  ����g  cCustomer Relationship Management Application, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullk:clr-namespace:Customer_Relationship_Management_Application,Customer_Relationship_Management_Application  5   	   =    7Customer_Relationship_Management_Application.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Llocal:clr-namespace:Customer_Relationship_Management_Application     5   	     � Title$&   Customer Relationship Management��5   	   $	��450��62   $��1021.8��6?   .��5	      �  � ColumnDefinitions 5
   
   �� 5      �� 5      .+�5   
   	� -   5        $��CustomerRadioButton��5      $��Customer��61   $
��Left=�6D   $��	28,86,0,0q�6_   $	��Top=�6r   $	��144��6�   6�   	� 5   
   -   5        $$��ProspectiveCustomerRadioButton��5      $��Prospective Customer��6<   $
��Left=�6[   $��
28,106,0,0q�6v   $	��Top=�6�   $	��144��6�   6�   �� 5   
   -   5        $��SubmitButton��5      $��Submit��6%   $
��Left=�66   $��391,317,0,0q�6Q   $	��Top=�6f   $��75��6~   6�   �� 5   
   -   5        $��ClearButton��5      $��Clear��6$   $
��Left=�64   $��311,317,0,0q�6O   $	��Top=�6d   $��75��6|   6�   �� 5   
   -   5        $��NameTextBox��5      $
��Left=�6%   $��26��6@   $��
92,136,0,0q�6L    �� TextWrapping$
 Wrap=�6`   $�� ��6t   $	��Top=�6|   $	��120��6�   �� 5   
   $��Name*��6   $
��Left=�6    $��
28,136,0,0q�6;   $	��Top=�6O   $��59��6g   �� 5   
   -   5        $��AgeComboBox��5      $
��Left=�6&   $��
92,180,0,0q�6A   $	��Top=�6U   $��71��6m   �� 5   
   $	��Age��6   $
��Left=�6   $��
28,178,0,0q�69   $	��Top=�6M   �� 5   
   $��Gender��6   $
��Left=�6!   $��
28,224,0,0q�6<   $	��Top=�6P   �� 5   
   -   5        $��GenderComboBox��5      $
��Left=�6)   $��
92,227,0,0q�6D   $	��Top=�6X   $��71��6p   �� 5   
   $��Email*��6   $
��Left=�6!   $��
28,270,0,0q�6<   $	��Top=�6P   �� 5   
   -   5        $��EmailTextBox��5      $
��Left=�6&   $��23��6A   $��
92,273,0,0q�6M   $
 Wrap=�6a   $�� ��6u   $	��Top=�6}   $	��120��6�   �� 5   
   -	   5        $��CustomerStatusLabel��5      $��Customer Status��6+   $
��Left=�6E   $��245,136,0,0q�6`   $	��Top=�6u   �� 5   
   -
   5        $��CustomerStatusComboBox��5      $
��Left=�61   $��346,139,0,0q�6L   $	��Top=�6a   $	��120��6y   �� 5   
   -   5        $��CommunicationChannelLabel��5      $$��How did you find out about us?��61   $
��Left=�6Z   $
��Left=�6|   $��247,177,0,0q�6�   $	��Top=�6�   $	��177��6�   �� 5   
   -   5        $"��CommunicationChannelComboBox��5      $
��Left=�67   $��253,208,0,0q�6R   $	��Top=�6g   $	��213��6   �� 5    
   -   5        $��CustomersListBox��5       $
��Left=�6*   $	��255��6E   $��11.8,126,0,0q�6R   $	��Top=�6h   $	��230��6�   $��1��6�   �� 5!   
   $��	Customers��6   $
��Left=�6$   $��Center=�6?   $��11.8,92,0,0q�6c   $	��Top=�6x   $	��228��6�   $��14(�6�   $��29��6�   $��1��6�   �� 5"   
   $��Prospective Customers��6   $
��Left=�60   $��Center=�6K   $��246.8,92,0,0q�6o   $	��Top=�6�   $	��230��6�   $��14(�6�   $��29��6�   $��1��6�   �� 5#   
   -   5        $!��ProspectiveCustomersListBox��5#      $
��Left=�65   $	��255��6P   $��246.8,126,0,0q�6]   $	��Top=�6t   $	��230��6�   $��1��6�   �� 5$   
   $&�� Customer Relationship Management��6   $
��Left=�6;   $��Center=�6V   $��10,36,-23.8,0q�6z   $	��Top=�6�   $��Center=�6�   $��44��6�   $
��1029��6�   $��2��6�   $��20(�6�   o� 5%   
   $
��Left=�6   $��27��6*   $��	10,10,0,0q�66   $	��Top=�6I   $	��100��6a   .@�5&      m� $
��File��6   $��27��6%   $	��100��61   .@�5'      m� -   5        $��About��5'      $��27��6*   $��	0,0,-23,0q�66   $
��Left=�6I   $	��123��6d   6p   m� 5(      -   5        $
��Exit��5(      $��27��6)   $��	0,0,-23,0q�65   $
��Left=�6H   $	��123��6c   6o   5)      5*      �� 5+   
   $��* required field��6   $��Italic$�6+   $
��Left=�6>   $��346,355,0,0q�6Y   $��Right=�6n   $	��Top=�6�   $	��120��6�   5,      5-      