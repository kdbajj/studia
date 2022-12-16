function deleteNode(root, key) {
  if (!root) return null;

  if (key < root.val) {
    //key-wartość którą chcemy usunąć
    root.left = deleteNode(root.left, key);
  } else if (key > root.val) {
    root.right = deleteNode(root.right, key);
  } else {
    if (!root.left && !root.right) {
      root = null;
    } else if (!root.right) {
      root = root.left;
    } else if (!root.left) {
      root = root.right;
    } else {
      let successor = findSuccessor(root);
      root.val = successor.val;
      root.right = deleteNode(root.right, successor.val);
    }
  }

  return root;
}

function findSuccessor(node) {
  //funkcja znajdująca potomka - jeżeli rodzic ma 2 dzieci to potomek jest w prawo najniżej
  if (node.right) {
    node = node.right;
    while (node.left) {
      node = node.left;
    }
    return node;
  } else {
    while (node.parent && node === node.parent.right) {
      node = node.parent;
    }
    return node.parent;
  }
}
