## Amanda M. Lincoln

# CIDM 3312: Final Project

FireWatch is a web application designed to promote community engagement with wildfire prevention and crisis management teams. As seen in the recent Panhandle wildfires, common circumstances that lead to wildfires – such as downed power lines – are sometimes known to  be issues prior to the wildfire but are not reported to the appropriate wildfire management agencies - precluding any possible preventative measures that could have been taken. This application aims to bridge this gap in communication by allowing members or organizations within the community to report activities or factors that historically have led to wildfires – such as downed power lines, unprescribed or illicit burns, use of pyrotechnic devices, etc. – online. Additionally, the FireWatch application allows organizations to upload wildfire advisories into a central location, allowing members of the community to easily find wildfire advisories applicable to their area more efficiently.

# Implemented features

The following functions have been implemented as of 9 May 2024:

1. Navigation Bar: Home, Wildfire Alerts, Submit a Report, and Privacy
2. Wildfire Advisories Listing with Sorting, Filtering, and Pagination
3. Details, partial Edit, and Delete Options for Wildfire Advisories
4. Report submission functionality

This application is currently configured to use SQLite in conjunction with EF Core for database functionality.

# Future implementations

Features for further development in the future include:

1. Fix error in WildfireAdvisories/Edit
2. Limit wildfire advisory edit and delete to authorized users/ roles
3. Allow users to upload an image with their report
4. Allow users to select their region and populate all advisories for their region and any macroregions they may belong to

