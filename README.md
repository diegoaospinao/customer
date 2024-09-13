# customer
Lab project for solid design pattern

## Step 1

Create a class that allows adding a client to a repository, possible errors must be controlled when adding the client.​

NOTE: It is not necessary to write the code that implements storage in the repository.​

## Step 2

A functionality must be added that allows a customer to obtain the discount depending on whether they are in the Gold or Silver category.

## Step 3

The system must allow you to calculate discounts of $5 for future customers. Make the necessary adjustments to the code above to have this functionality. Keep in mind that this future client will not be stored in the repository.

## Step 4

Let's assume that our “Customer” class has become a super-used component and is now being used in more than 1000 companies that are very happy with the “Customer” class​

Now we have new companies that want to use this class but also want the class to allow reading customer information, but the 1000 companies that already use it do not need this new functionality.​

## Step 5

In the first exercise, a class was created to handle exceptions when saving a client, now the log must be allowed to be managed in: Text file or Mail or in the Event Viewer. Companies define how they want to store the error.