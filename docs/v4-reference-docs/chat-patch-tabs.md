---
title: "Update tab in chat"
description: "Update the properties of the specified tab in a chat."
author: "subray"
ms.localizationpriority: medium
ms.prod: "microsoft-teams"
doc_type: apiPageType
---

# Update tab in chat

Namespace: microsoft.graph

Update the properties of the specified [tab](../resources/teamstab.md) in a [chat](../resources/chat.md). 
This can be used to configure the content of the tab.

> **Note**: If the chat is associated with an [onlineMeeting](../resources/onlinemeeting.md) instance, then, effectively, the tab pinned in the meeting will be updated.

## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).


|Permission type      | Permissions (from least to most privileged)              |
|:--------------------|:---------------------------------------------------------|
|Delegated (work or school account) | TeamsTab.ReadWriteSelfForChat, TeamsTab.ReadWriteForChat, TeamsTab.ReadWrite.All |
|Delegated (personal Microsoft account) | Not supported.    |
|Application | TeamsTab.ReadWriteSelfForChat.All, TeamsTab.ReadWriteForChat, TeamsTab.ReadWrite.All |


## HTTP request

<!-- {
  "blockType": "ignored"
}
-->
```http
PATCH /chats/{chat-id}/tabs/{tab-id}
```

## Request headers
| Header       | Value |
|:---------------|:--------|
| Authorization  | Bearer {token}. Required.  |
| Content-Type  | application/json. Required.  |

## Request body
In the request body, supply a JSON representation of [tab](../resources/teamstab.md) object.

## Response

If successful, this method returns a `200 OK` response code and the updated **teamsTab** resource in the response body.

## Examples
### Example 1: Update the name of a tab in a chat

#### Request
The following is an example of the request.


# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "update_tabs_in_chat",
  "sampleKeys": ["19:d65713bc498c4a428c71ef9353e6ce20@thread.v2", "794f0e4e-4d10-4bb5-9079-3a465a629eff"]
}-->
```http
PATCH https://graph.microsoft.com/v1.0/chats/19:d65713bc498c4a428c71ef9353e6ce20@thread.v2/tabs/794f0e4e-4d10-4bb5-9079-3a465a629eff
Content-type: application/json

{
  "displayName": "My Contoso Tab - updated again"
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var teamsTab = new TeamsTab
{
	DisplayName = "My Contoso Tab - updated again"
};

await graphClient.Chats["{chat-id}"].Tabs["{teamsTab-id}"]
	.Request()
	.UpdateAsync(teamsTab);

```


 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

#### Response

<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "microsoft.graph.teamsTab"
}
-->

```http
HTTP/1.1 200 OK
Content-type: application/json

{
  "id": "794f0e4e-4d10-4bb5-9079-3a465a629eff",
  "displayName": "My Contoso Tab - updated again",
  "teamsAppId": "06805b9e-77e3-4b93-ac81-525eb87513b8",
  "configuration": {
    "entityId": "2DCA2E6C7A10415CAF6B8AB6661B3154",
    "contentUrl": "https://www.contoso.com/Orders/2DCA2E6C7A10415CAF6B8AB6661B3154/tabView",
    "websiteUrl": "https://www.contoso.com/Orders/2DCA2E6C7A10415CAF6B8AB6661B3154",
    "removeUrl": "https://www.contoso.com/Orders/2DCA2E6C7A10415CAF6B8AB6661B3154/uninstallTab"
  },
  "sortOrderIndex": "20",
  "webUrl": "https://teams.microsoft.com/l/entity/com.microsoft.teamspace.tab.web/_djb2_msteams_prefix_193fe248-24e6-478f-a66c-ede9ce6dd547?context=%7b%0d%0a++%22context%22%3a+%22chat%22%2c%0d%0a++%22chatId%22%3a+%2219%3ad65713bc498c4a428c71ef9353e6ce20%40thread.v2%22%2c%0d%0a++%22subEntityId%22%3a+null%0d%0a%7d&tenantId=139d16b4-7223-43ad-b9a8-674ba63c7924"
}
```

## See also

- [Configuring the built-in tab types](/graph/teams-configuring-builtin-tabs)
- [Update tab in channel](channel-patch-tabs.md)

<!-- uuid: 8fcb5dbc-d5aa-4681-8e31-b001d5168d79
2015-10-25 14:57:30 UTC -->
<!--
{
  "type": "#page.annotation",
  "description": "Update tab in chat",
  "keywords": "",
  "section": "documentation",
  "tocPath": "",
  "suppressions": []
}
-->


