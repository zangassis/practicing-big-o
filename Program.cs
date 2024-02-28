// O(1) - Constant time complexity

int[] array = new int[] { 10, 20, 30, 40, 50 };

int element = array[2];

Console.WriteLine($"Element at index 2: {element}");

// O(log n) - Logarithmic execution time

int BinarySearch(int[] arr, int target)
{
    int left = 0;
    int right = arr.Length - 1;

    while (left <= right)
    {
        int mid = left + (right - left) / 2;

        if (arr[mid] == target)
            return mid;
        if (arr[mid] > target)
            right = mid - 1;
        else
            left = mid + 1;
    }
    return -1;
}

int[] arr = { 2, 5, 6, 12, 16, 23, 38, 56, 72, 91 };
int target = 23;
int result = BinarySearch(arr, target);

if (result is not -1)
    Console.WriteLine($"Element found in position: {result}");
else
    Console.WriteLine("Element not found in array");

// O(n) - Linear execution time

int[] unorderedArray = { 3, 1, 6, 12, 16, 23, 38, 56, 72, 83 };
int targetElement = 72;

int LinearSearch(int[] unorderedArray, int targetElement)
{
    for (int i = 0; i < unorderedArray.Length; i++)
    {
        if (unorderedArray[i] == targetElement)
        {
            return i;
        }
    }
    return -1;
}

int resultIndex = LinearSearch(unorderedArray, targetElement);

if (resultIndex != -1)
    Console.WriteLine($"Element found at index: {resultIndex}");
else
    Console.WriteLine("Element not found in the array");

// O(n log n) - Log-linear running time

int[] originalArray = { 12, 4, 5, 6, 7, 3, 1, 15, 8, 9 };

Console.WriteLine("Original array:");
PrintArray(originalArray);

QuickSort(originalArray, 0, originalArray.Length - 1);

Console.WriteLine("\nOrdered array:");
PrintArray(originalArray);

void QuickSort(int[] originalArray, int low, int high)
{
    if (low < high)
    {
        int pivot = Partition(originalArray, low, high);

        QuickSort(originalArray, low, pivot - 1);
        QuickSort(originalArray, pivot + 1, high);
    }
}

int Partition(int[] originalArray, int low, int high)
{
    int pivot = originalArray[high];
    int i = low - 1;

    for (int j = low; j < high; j++)
    {
        if (originalArray[j] < pivot)
        {
            i++;
            Swap(originalArray, i, j);
        }
    }

    Swap(originalArray, i + 1, high);

    return i + 1;
}

void Swap(int[] originalArray, int i, int j)
{
    int temp = originalArray[i];
    originalArray[i] = originalArray[j];
    originalArray[j] = temp;
}

void PrintArray(int[] arr)
{
    foreach (int num in arr)
    {
        Console.Write(num + " ");
    }
    Console.WriteLine();
}

// O(n^2) - Quadratic execution time

int[] originalArray = { 64, 34, 25, 12, 22, 11, 90 };
        
Console.WriteLine("Original array:");
PrintArray(originalArray);

BubbleSort(originalArray);

Console.WriteLine("\nOrdered array:");
PrintArray(originalArray);

static void BubbleSort(int[] arr)
{
    int n = arr.Length;
    for (int i = 0; i < n - 1; i++)
    {
        for (int j = 0; j < n - i - 1; j++)
        {
            if (arr[j] > arr[j + 1])
            {
                int temp = arr[j];
                arr[j] = arr[j + 1];
                arr[j + 1] = temp;
            }
        }
    }
}

static void PrintArray(int[] arr)
{
    foreach (int num in arr)
    {
        Console.Write(num + " ");
    }
    Console.WriteLine();
}