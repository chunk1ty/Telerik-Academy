using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TradeAndTravel
{
    public class AdvancedInteractionManager : InteractionManager
    {
        protected override Person CreatePerson(string personTypeString, string personNameString, Location personLocation)
        {
            switch (personTypeString)
            {
                case "merchant":
                    return new Merchant(personNameString, personLocation);
                default:
                    return base.CreatePerson(personTypeString, personNameString, personLocation);
            }
            
        }

        protected override Item CreateItem(string itemTypeString, string itemNameString, Location itemLocation, Item item)
        {
            switch (itemTypeString)
            {
                case "weapon":
                    return new Weapon(itemNameString, itemLocation);
                case "wood":
                    return new Wood(itemNameString, itemLocation);
                case "iron":
                    return new Iron(itemNameString, itemLocation);
                default:
                    return base.CreateItem(itemTypeString, itemNameString, itemLocation, item);
            }
        }

        protected override Location CreateLocation(string locationTypeString, string locationName)
        {
            switch (locationTypeString)
            {
                case "mine":
                    return new Mine(locationName);
                case "forest":
                    return new Forest(locationName);
                default:
                    return base.CreateLocation(locationTypeString, locationName);
            }
        }

        protected override void HandlePersonCommand(string[] commandWords, Person actor)
        {
            switch (commandWords[1])
            {
                case "gather":
                    HandleGatherInteraction(commandWords, actor);
                    break;
                case "craft":
                    {
                        string itemTypeToCraft = commandWords[2];
                        string chosenItemName = commandWords[3];
                        var actorInventory = actor.ListInventory();
                        if (itemTypeToCraft == "armor")
                        {
                            if (InventoryHasItemType(ItemType.Iron, actorInventory))
                            {
                                AddToPerson(actor, new Armor(chosenItemName));
                            }
                        }
                        else if (itemTypeToCraft == "weapon")
                        {
                            if (InventoryHasItemType(ItemType.Iron, actorInventory) &&
                                InventoryHasItemType(ItemType.Wood, actorInventory))
                            {
                                AddToPerson(actor, new Weapon(chosenItemName));
                            }
                        }
                    }
                    break;
                default:
                    base.HandlePersonCommand(commandWords, actor);
                    return;
            }
        }

        private void HandleGatherInteraction(string[] commandWords, Person actor)
        {
            string chosenItemName = commandWords[2];
            var gatheringLocation = actor.Location as IGatheringLocation;
            if (gatheringLocation != null)
            {
                var requiredItemType = gatheringLocation.RequiredItem;
                var actorInventory = actor.ListInventory();

                bool actorHasItemType = InventoryHasItemType(requiredItemType, actorInventory);

                if (actorHasItemType)
                {
                    this.AddToPerson(actor, gatheringLocation.ProduceItem(chosenItemName));
                }
            }
        }

        private static bool InventoryHasItemType(ItemType requiredItemType, List<Item> actorInventory)
        {
            bool actorHasItemType = false;
            foreach (var item in actorInventory)
            {
                if (item.ItemType == requiredItemType)
                {
                    actorHasItemType = true;
                    break;
                }
            }
            return actorHasItemType;
        }
    }
}
