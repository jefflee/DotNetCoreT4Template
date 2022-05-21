
# Reminders

 - Need to make sure it is TextTemplatingFilePreprocessor, when adding a Runtime Text Template

        <None Update="T4\AppSettingsT4.tt">
            <Generator>TextTemplatingFilePreprocessor</Generator>
            <LastGenOutput>AppSettingsT4.cs</LastGenOutput>
        </None>


- Add this to the first line in tt file 

        <#@ template visibility="internal" #>

# References
- [Use T4 TextTemplatingFilePreprocessor in .NET Standard or PCL libraries](https://blog.rsuter.com/use-t4-texttemplatingfilepreprocessor-in-net-standard-or-pcl-libraries/)
