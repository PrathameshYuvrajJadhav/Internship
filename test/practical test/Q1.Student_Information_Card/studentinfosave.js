let info = [];

// Load contacts from localStorage
if (localStorage.getItem("info") != null) {
  info = JSON.parse(localStorage.getItem("info"));
}

// Show contacts when page loads
showInfo();

// Form Submit Event
document.querySelector(".info-form").addEventListener("submit", function (e) 
{
    e.preventDefault();

    let name = document.getElementById("uname").value;

    let domain = document.getElementById("course").value;

    info.push({
      name: name,
      domain: domain,
    });

    localStorage.setItem("info", JSON.stringify(info));

    document.getElementById("uname").value = "";
    document.getElementById("course").value = "";

    showInfo();
});

// Display Info
function showInfo() {
  let output = "";

  info.forEach(function (student, index) {
    output += `
        <div class="card">

            <h3>${student.name}</h3>

            <p>${student.domain}</p>

            <button class="btn-delete"
             onclick="deleteContact(${index})">
            Delete Contact
            </button>

        </div>
        `;
  });

  let phonebook = document.getElementById("phonebook");

  if (info.length === 0) {
    phonebook.innerHTML =
      'Nothing to show! Use "Add a contact" section above to add contact.';
  } else {
    phonebook.innerHTML = output;
  }
}

// Delete Contact
function deleteContact(index) {
  info.splice(index, 1);

  localStorage.setItem("info", JSON.stringify(info));

  showInfo();
}
