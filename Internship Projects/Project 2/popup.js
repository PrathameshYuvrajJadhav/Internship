let contacts = [];

// Load contacts from localStorage
if (localStorage.getItem("contacts") != null) {
  contacts = JSON.parse(localStorage.getItem("contacts"));
}

// Show contacts when page loads
showContacts();

// Form Submit Event
document.querySelector(".contact-form").addEventListener("submit", function (e) 
{
    e.preventDefault();

    let name = document.getElementById("uname").value;

    let phone = document.getElementById("contact").value;

    contacts.push({
      name: name,
      phone: phone,
    });

    localStorage.setItem("contacts", JSON.stringify(contacts));

    document.getElementById("uname").value = "";
    document.getElementById("contact").value = "";

    showContacts();
});

// Display Contacts
function showContacts() {
  let output = "";

  contacts.forEach(function (contact, index) {
    output += `
        <div class="card">

            <h3>${contact.name}</h3>

            <p>${contact.phone}</p>

            <button class="btn-delete"
             onclick="deleteContact(${index})">
            Delete Contact
            </button>

        </div>
        `;
  });

  let phonebook = document.getElementById("phonebook");

  if (contacts.length === 0) {
    phonebook.innerHTML =
      'Nothing to show! Use "Add a contact" section above to add contact.';
  } else {
    phonebook.innerHTML = output;
  }
}

// Delete Contact
function deleteContact(index) {
  contacts.splice(index, 1);

  localStorage.setItem("contacts", JSON.stringify(contacts));

  showContacts();
}

//searching contact
document.getElementById("searchTxt").addEventListener("input", function () {
  let searchValue = this.value.toLowerCase();

  let cards = document.getElementsByClassName("card");

  Array.from(cards).forEach(function (card) {
    let contactName = card
      .getElementsByTagName("h3")[0]
      .innerText.toLowerCase();

    if (contactName.includes(searchValue)) {
      card.style.display = "block";
    } else {
      card.style.display = "none";
    }
  });
});
