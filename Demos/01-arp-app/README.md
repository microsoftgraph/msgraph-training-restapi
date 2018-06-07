# Create an Azure AD web application with the App Registration Portal

In this demo, you will create a new Azure AD native application using the App Registry Portal (ARP).

1. Open a browser and navigate to the **App Registry Portal**: **apps.dev.microsoft.com** and login using a **personal account** (aka: Microsoft Account) or **Work or School Account**.
1. Select **Add an app** at the top of the page.
1. On the **Register your application** page, set the **Application Name** to **WebO365CalendarEvents** and select **Create**.

    ![Screenshot of creating a new app in the App Registration Portal website](../../Images/arp-create-app-01.png)

1. On the **WebO365CalendarEvents Registration** page, under the **Properties** section, copy the **Application Id** Guid as you will need it later.

    ![Screenshot of newly created application's ID](../../Images/arp-create-app-02.png)

1. Scroll down to the **Application Secrets** section

    1. Select **Generate New Password**.
    1. In the **New password generated**, copy the contents of the box as you will need it later. *This password is never shown again, so make sure you copy it now.*

    ![Screenshot of newly created application's password](../../Images/arp-create-app-03.png)

1. Scroll down to the **Platforms** section.

    1. Select **Add Platform**.
    1. In the **Add Platform** dialog, select **Web**.

        ![Screenshot creating a platform for the app](../../Images/arp-create-app-04.png)

    1. In the **Web** platform box added by the previous dialog's selection, enter the URL **https://localhost:1234** for the **Redirect URLs**.

        ![Screenshot of the newly added Web platform for the application](../../Images/arp-create-app-05.png)

        > You will eventually have to come back to add a new URL to this when we know the SSL of the ASP.NET application that you will build in an exercise later in this lab.

1. In the **Microsoft Graph Permissions** section, select **Add** next to the **Delegated Permissions** subsection.

    ![Screenshot of the Add button for adding a delegated permission](../../Images/arp-add-permission-01.png)

    In the **Select Permission** dialog, locate and select the permission **Calendars.Read** and select **OK**:

      ![Screenshot of adding the Calendars.Read permission](../../Images/arp-add-permission-02.png)

      ![Screenshot of the newly added Calendars.Read permission](../../Images/arp-add-permission-03.png)

1. Scroll to the bottom of the page and select **Save**.