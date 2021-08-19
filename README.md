# OpenCodeDev.NetCMS.Plugin
Plugin base starte for NetCMS


## Plugin Info
The plugin info JSON file is a setting file for the information related to the plugin.
### General
There are several standard general information to define for a plugin.

**Name** : If public (NetCMS' Valid Repos), unique name of the plugin (Assembly most likely). If private the name only but note that it could result to conflict if private dependency's name has the same as a public one.

**Author** : Who created the plugin? (Default: null)

**Company** : Which Company? (Default: null) (Visual is *by Author at Company* or something like that... we'll see)

Note: Author or/and Company mustn't be null, one is required.

**Version** : Must be defined as "1.0.0" format, no letter, no special chars. major.feature.fix

### Dependencies

**Name** : Unique name of the plugin (Public or Private)

Note: if 2 plugin require the same dependency, cli will grab matching version support of the 2 plugins, else it wont be able the start... NetCMS official repos will try to make sure developers are support wide range of version among popular plugin or will reject plugin to ensure maximum compatibility.

**Version** : Simple format with wildcard. "1.0.\*" (Any Fixes), "1.\*" (Any Features), "1.\*, 2.\*" (1.1.0, 1.2.0, 1.3.1 ... 2.1.0, 2.1.1, 2.2.3 ... )

Note: We will try to find a match between cross dependencies, 2 versions of the same dependency cannot co-exist due to database and potential relationships between plugins.

**Private** : If dependency is private, we will ensure not to grab against our official repos. Same rule applies tho, cannot have co-existance between versions.