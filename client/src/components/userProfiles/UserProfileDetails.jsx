import { useParams } from "react-router-dom";
import { useEffect, useState } from "react";
import { getUserProfileById } from "../../managers/userProfileManager";
import { Table } from "reactstrap";

export const UserProfileDetails = () => {
  const [userProfile, setUserProfile] = useState({});
  const { id } = useParams();

  useEffect(() => {
    getUserProfileById(id).then((obj) => setUserProfile(obj));
  }, [id]);

  return (
    <>
      <h1>User Details</h1>
      <Table>
        <thead>
          <tr>
            <th>Address</th>
            <th>Email</th>
            <th>Username</th>
          </tr>
        </thead>
        <tbody>
          <tr key={id}>
            <td>{userProfile.address}</td>
            <td>{userProfile?.email}</td>
            <td>{userProfile.userName}</td>
          </tr>
        </tbody>
      </Table>
    </>
  );
};
