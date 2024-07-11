const apiUrl = "/api/userprofile";

export const getUserProfiles = () => {
  return fetch(apiUrl).then((res) => res.json());
};

export const getUserProfileById = (id) => {
  return fetch(`${apiUrl}/${id}`).then((res) => res.json());
};
