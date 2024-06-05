# Good Exercise

## Description

SellIn and Quality Values: Each item in our inventory possesses a SellIn value, indicating the number of days left before it must be sold, and a Quality value, reflecting its desirability.
Daily Updates: At the close of each day, our system automatically adjusts both the SellIn and Quality values for all items.
Now, let's delve into the intricacies:

Quality Degradation: As an item's sell-by date approaches, its Quality diminishes. After the sell-by date, the rate of degradation doubles.
Quality Constraints: Quality values never dip below zero, ensuring our customers always receive goods of at least some value. Furthermore, the Quality of an item is capped at 50.
Special Items: Certain items exhibit unique behavior. "Aged Brie" increases in quality over time, while "Sulfuras," a legendary artifact, retains its legendary quality of 80 indefinitely. "Backstage passes" gain value as their sell-by date approaches, with a significant boost in the final days before a concert.
New Additions: We've recently partnered with a supplier of conjured items, which degrade in quality at twice the rate of regular items.

Remember, while an item's quality cannot exceed 50 under normal circumstances, "Sulfuras" remains a legendary exception.


## Estructura del Proyecto
- **/Properties**: Archivos relacionados con la configuración y propiedades del proyecto.
- **/Models**: Classes that represent entities or components of the application model.
- **/Tests**: Unit test files.
- **/Enums** (o **/Constants**): Constants or enumerations used in the project.


## Requirements
- **.net framework 4.5.2**


