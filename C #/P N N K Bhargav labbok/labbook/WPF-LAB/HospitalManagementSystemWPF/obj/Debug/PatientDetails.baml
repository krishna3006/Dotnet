   M S B A M L   `   `   `  ����V  RHospitalManagementSystemWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:HospitalManagementSystemWPFHospitalManagementSystemWPF  5   	   0    *HospitalManagementSystemWPF.PatientDetails   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ;local)clr-namespace:HospitalManagementSystemWPF     5   	     � Title$  PatientDetails��5   	   $	��450��6    $��468.42��6-   .��5	      �� -   5        .@�5
   
   �� $��Add a Patient��6   .��5      � $��32,4,-13,-18q�6    � ColumnDefinitions 5      �� 5      $
��111* �6'   �� 5      $	��33* �6'   �� 5      $	��35* �6'   �� 5      $
��607* �6'   .+�5      �� $��PatientId :��6   $	��Top=�6.   $��Center=�6F   $��13,81,307,0q�6c   $��Arial)�6x   $
��Bold"�6�   $	��115��6�   $��4��6�   �� 5      -   5         ��Name$ txtPatientid��5       �� 
IsReadOnly . $
��Left=�6B   $��23��6]   $��	59,81,0,0q�6i    �� TextWrapping$
 Wrap=�6|   $�� ��6�   $	��Top=�6�   $	��152��6�   $��3��6�   �� 5      $��Patient Name :��6   $��Center=�61   $	��Top=�6N   $��13,137,307,0q�6f    J� RenderTransformOrigin$ 1.223,1.385&�6|   $��Arial)�6�   $
��Bold"�6�   $	��115��6�   $��4��6�   �� 5      -   5        $ txtPatientname��5      $
��Left=�62   $��23��6M   $��
59,138,0,0q�6Y   $
 Wrap=�6m   $�� ��6�   $	��Top=�6�   $	��152��6�   $��3��6�   �� 5      $��Patient Type :��6   $��Center=�61   $	��Top=�6N   $��11,189,307,0q�6f   $��Arial)�6|   $
��Bold"�6�   $	��117��6�   $��4��6�   �� 5      -   5         ��Name$ cbPatienttype��5      $��Right=�62   $��0,189,141,0q�6N   $	��Top=�6c   $	��136��6{   $��3��6�   �� 5      -   5        $��Submit��5      $��Center=�6*   $��72��6G   $��20,276,244,89q�6R   $��3��6~   5      5      �� 5   
   $��View Patient Info ��6   .��5      &   System.Windows.Controls.DataGrid  -   5        $��	dgPatient��5      $��118,96,99,51q�6(   5      5      5      5       