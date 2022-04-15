const bookCardTemplate = document.querySelector("[data-book-template]")
const bookCardContainer = document.querySelector("[data-book-cards-container]")
const searchInput = document.querySelector("[data-search]")

const element = document.getElementById("SearchButton");

// array for the bookss
let books = []

// get the value 
function getVal()
{
    const val = searchInput.value;
    return val;
    // console.log(val);
}

// FUNCTION FOR SORTING THE BOOKS ALPHABETICALLY

function compareStrings(a, b) {
    // Assuming you want case-insensitive comparison
    a = a.toLowerCase();
    b = b.toLowerCase();
    return (a < b) ? -1 : (a > b) ? 1 : 0;
  }

//fetching the json

const wait = fetch("/data/books.json")
  .then(res => res.json())
  .then(data => {

    // here we sort the books

    data.sort(function(a, b)
    {
        return compareStrings(a.title, b.title);
    })

    // map for the books

    books = data.map(book => {

      const card = bookCardTemplate.content.cloneNode(true).children[0]

      //selector for consts
      const header = card.querySelector("[data-header]")
      const body = card.querySelector("[data-body]")
      const author = card.querySelector("[data-author]")
      const mainGenre = card.querySelector("[data-mainGenre]")
      const genre = card.querySelector("[data-genre]")
      const type = card.querySelector("[data-type]")
      const image = card.querySelector("[data-image]")

      // takes the value from the json and adds it to the div where is supposed to go
      //Example: it search in the template for ["data-image"] takes the imageLink from the json and adds it to the src of the img and shows up
      header.textContent = book.title
      author.textContent = book.author
      mainGenre.textContent = book.mainGenre
      genre.textContent = book.genre
      type.textContent = book.type
      image.src = book.imageLink

      //the finished card that shows up as the finished template 
      bookCardContainer.append(card)
      
      //returning the values
      return { title: book.title, author: book.author, imageLink: book.imageLink, type: book.type, genre: book.genre, mainGenre: book.mainGenre, element: card }
    })
  })
 
  // We use async to do the searching for fiction books after the json is fetched
  //function for searching fiction books

 async function searchFiction(){
    let finished= await wait;
    const value = "Fiction";
    const value2 = getVal().toLowerCase();
    books. forEach(book => {
        const isVisible=
        (book.mainGenre == value && 
          book.title.toLowerCase().includes(value2)) ||
          (book.mainGenre == value && 
            book.author.toLowerCase().includes(value2))
        book.element.classList.toggle("hide", !isVisible)
    })
  }

  //function for searching nonfiction books

  async function searchNonFiction(){
    let finished= await wait;
    const value = "NonFiction";
    const value2 = getVal().toLowerCase();
    books.forEach(book => {
        const isVisible=
        (book.mainGenre == value && 
        book.title.toLowerCase().includes(value2)) ||
        (book.mainGenre == value && 
          book.author.toLowerCase().includes(value2))
        book.element.classList.toggle("hide", !isVisible)
    })
  }

//function for searching fiction books

  async function searchAdultBooks(){
    let finished= await wait;
    const value = "Adult";
    const value2 = getVal().toLowerCase();
    books.forEach(book => {
        const isVisible=
        (book.type == value && 
          book.title.toLowerCase().includes(value2)) ||
          (book.type == value &&
          book.author.toLowerCase().includes(value2))
        book.element.classList.toggle("hide", !isVisible)
    })
  }

//function for searching fiction action books

  async function searchActionBooks(){
    let finished= await wait;
    const value = "Action";
    const value2 = getVal().toLowerCase();
    books.forEach(book => {
        const isVisible=
        (book.genre == value && 
          book.title.toLowerCase().includes(value2)) ||
          (book.genre == value && 
          book.author.toLowerCase().includes(value2))
        book.element.classList.toggle("hide", !isVisible)
    })
  }

//function for searching fiction adventure books

  async function searchAdventureBooks(){
    let finished= await wait;
    const value = "Adventure";
    const value2 = getVal().toLowerCase();
    books.forEach(book => {
        const isVisible=
        (book.genre == value && 
          book.title.toLowerCase().includes(value2)) ||
          (book.genre == value && 
          book.author.toLowerCase().includes(value2))
        book.element.classList.toggle("hide", !isVisible)
    })
  }

  //function for searching fiction books

  async function searchBiographyBooks(){
    let finished= await wait;
    const value = "Biography";
    const value2 = getVal().toLowerCase();
    books.forEach(book => {
        const isVisible=
        (book.genre == value && 
          book.title.toLowerCase().includes(value2)) ||
          (book.genre == value && 
          book.author.toLowerCase().includes(value2))
        book.element.classList.toggle("hide", !isVisible)
    })
  }

//function for searching children books

  async function searchChildrenBooks(){
    let finished= await wait;
    const value = "Children";
    const value2 = getVal().toLowerCase();
    books.forEach(book => {
        const isVisible=
        (book.type == value && 
          book.title.toLowerCase().includes(value2)) ||
          (book.type == value &&
          book.author.toLowerCase().includes(value2))
        book.element.classList.toggle("hide", !isVisible)
    })
  }

//function for searching fiction drama books

  async function searchDramaBooks(){
    let finished= await wait;
    const value = "Drama";
    const value2 = getVal().toLowerCase();
    books.forEach(book => {
        const isVisible=
        (book.genre == value && 
        book.title.toLowerCase().includes(value2)) ||
        (book.genre == value && 
        book.author.toLowerCase().includes(value2))
        book.element.classList.toggle("hide", !isVisible)
    })
  }

//function for searching fiction history books

  async function searchFictionHistoryBooks(){
    let finished= await wait;
    const value = "History";
    const value2 = "Fiction";
    const value3 = getVal().toLowerCase();
    books.forEach(book => {
        const isVisible=
        (book.genre == value &&
        book.mainGenre== value2 &&
         book.title.toLowerCase().includes(value3))||
        (book.genre == value &&
        book.mainGenre== value2 && 
        book.author.toLowerCase().includes(value3))
        book.element.classList.toggle("hide", !isVisible)
    })
  }

//function for searching "learning books"

  async function searchLearningBooks(){
    let finished= await wait;
    const value = "Learn";
    const value2 = getVal().toLowerCase();
    books.forEach(book => {
      console.log(book.author)
        const isVisible=
        (book.genre == value &&
         book.title.toLowerCase().includes(value2))||
        (book.genre == value &&
        book.author.toLowerCase().includes(value2))
        book.element.classList.toggle("hide", !isVisible)
    })
  }

//function for searching nonfiction history books

  async function searchNonFictionHistoryBooks(){
    let finished= await wait;
    const value = "History";
    const value2 = "NonFiction";
    const value3 = getVal().toLowerCase();
    books.forEach(book => {
        const isVisible=
        (book.genre == value &&
        book.mainGenre== value2 &&
         book.title.toLowerCase().includes(value3))||
        (book.genre == value &&
        book.mainGenre== value2 && 
        book.author.toLowerCase().includes(value3))
        book.element.classList.toggle("hide", !isVisible)
    })
  }
  // async function searchNonActionBooks(){
  //   let finished= await wait;
  //   const value = "Action";
  //   const value2 = "NonFiction";
  //   const value3 = getVal().toLowerCase();
  //   console.log("a");
  //   books.forEach(book => {
  //       const isVisible=
  //       (book.genre == value &&
  //       book.mainGenre== value2 &&
  //        book.title.toLowerCase().includes(value3))||
  //       (book.genre == value &&
  //       book.mainGenre== value2 && 
  //       book.author.toLowerCase().includes(value3))
  //       book.element.classList.toggle("hide", !isVisible)
  //   })
  // }

//function for searching fiction romance books

  async function searchRomanceBooks(){
    let finished= await wait;
    const value = "Romance";
    const value2 = getVal().toLowerCase();
    console.log(value2);
    books.forEach(book => {
        const isVisible=
        (book.genre == value  && 
        book.title.toLowerCase().includes(value2)) ||
        (book.genre == value  &&
        book.author.toLowerCase().includes(value2))
        book.element.classList.toggle("hide", !isVisible)
    })
  }

  //function for searching teen books

  async function searchTeenBooks(){
    let finished= await wait;
    const value = "Teen" ;
    const value2 = getVal().toLowerCase();
    books.forEach(book => {
        const isVisible=
        (book.type == value && 
        book.title.toLowerCase().includes(value2)) ||
        (book.type == value &&
        book.author.toLowerCase().includes(value2))
        // book.author.toLowerCase().includes(value)
        book.element.classList.toggle("hide", !isVisible)
    })
  } 
  
  // function searchTeen(){
  //   const value = getVal().toLowerCase();
  //   console.log(value);
  //   books.forEach(book => {
  //       const isVisible =
  //       book.type == "Teen" &&
  //       book.title.toLowerCase().includes(value) 
  //       // book.author.toLowerCase().includes(value) 
       
  //       book.element.classList.toggle("hide", !isVisible)
  //   })
  // }
