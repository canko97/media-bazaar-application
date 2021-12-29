<?php
class Item
{
   private int $itemId;
   private string $itemName;
   private double $itemPrice;
   private string $itemDescription; 
   private int $category;
   private int $inStoreAmount;
   private int  $warehouseAmount;
   private int $minQuantity;
   private int $maxQuantity;

   function __construct(int $itemId, string $itemName, double $itemPrice, string $itemDescription,
   int $category, int $inStoreAmount, int $warehouseAmount, int $minQuantity, int $maxQuantity)
   {
        $this->itemId = $itemId;
        $this->itemName = $itemName;
        $this->itemPrice = $itemPrice;
        $this->itemDescription = $itemDescription;
        $this->category = $category;
        $this->inStoreAmount = $inStoreAmount;
        $this->warehouseAmount = $warehouseAmount;
        $this->minQuantity = $minQuantity;
        $this->maxQuantity = $maxQuantity;
   }

}

?>