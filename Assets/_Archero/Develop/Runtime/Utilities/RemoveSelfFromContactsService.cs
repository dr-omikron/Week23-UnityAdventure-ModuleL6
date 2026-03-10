using UnityEngine;

namespace _Archero.Develop.Runtime.Utilities
{
    public class RemoveSelfFromContactsService
    {
        public void Remove(Buffer<Collider> contacts, Collider contactCollider)
        {
            int indexToRemove = -1;

            for (int i = 0; i < contacts.Count; i++)
            {
                if (contacts.Items[i] == contactCollider)
                {
                    indexToRemove = i;
                    break;
                }
            }

            if (indexToRemove >= 0)
            {
                for (int i = indexToRemove; i < contacts.Count - 1; i++)
                {
                    contacts.Items[i] = contacts.Items[i + 1];
                }

                contacts.Count--;
            }
        }
    }
}
